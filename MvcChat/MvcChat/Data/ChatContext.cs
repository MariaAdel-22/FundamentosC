using Microsoft.EntityFrameworkCore;
using MvcChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChat.Data
{
    public class ChatContext:DbContext
    {
        public ChatContext(DbContextOptions<ChatContext>options):base(options) { 
        
        }

        public DbSet<Chats> Chats { get; set; }
        public DbSet<Chat> ChatAll { get; set; }
        public DbSet<Protectora> Protectoras { get; set; }
    }
}
