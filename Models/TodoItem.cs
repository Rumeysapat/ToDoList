using System;
namespace ToDoListApp.Models
{
 public class TodoItem
 {
 public int Id { get; set; }
 public string Title { get; set; }
 public bool IsDone { get; set; }
 public DateTime CreatedAt { get; set; }
 }
}