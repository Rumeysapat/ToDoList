using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ToDoListApp.Models;
namespace ToDoListApp.Controllers
{
 public class TodoController : Controller
 {
 private readonly ApplicationDbContext _context;
public TodoController(ApplicationDbContext context)
 {
 _context = context;
 }
public IActionResult Index()
 {
 var todoItems = _context.TodoItems.ToList();
 return View(todoItems);
 }
[HttpPost]
 public IActionResult Create(string title)
 {
 if (!string.IsNullOrEmpty(title))
 {
 var todoItem = new TodoItem
 {
 Title = title,
 IsDone = false,
 CreatedAt = DateTime.Now
 };
_context.TodoItems.Add(todoItem);
 _context.SaveChanges();
 }
return RedirectToAction("Index");
 }
// Add other actions for marking items as done, deleting, etc.
 }
}