using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoMVC.Models;

namespace TodoMVC.Data
{
    public class TodoMVCContext : DbContext
    {
        public TodoMVCContext (DbContextOptions<TodoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TodoMVC.Models.TodoTask> TodoTask { get; set; } = default!;
    }
}
