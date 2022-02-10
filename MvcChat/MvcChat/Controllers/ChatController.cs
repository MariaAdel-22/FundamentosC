using Microsoft.AspNetCore.Mvc;
using MvcChat.Models;
using MvcChat.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChat.Controllers
{
    public class ChatController : Controller
    {
        private RepositoryChat repo;

        public ChatController(RepositoryChat repo) {

            this.repo = repo;
        }

        public Dictionary<int, string> Rooms(){

            Dictionary<int, string> rooms = new Dictionary<int, string>();

            List<int> chats = this.repo.GetChats();

            for (int i=0;i<chats.Count;i++) {

                string nombreSala = this.repo.GetProtectora(chats[i]);

                if (nombreSala != null) {

                    rooms.Add(chats[i],nombreSala);

                }
            }

            return rooms;
        }
        
        public IActionResult Index()
        {
            Dictionary<int, string> rooms = this.Rooms();
            return View(rooms);
        }

        public IActionResult Room(int room) {

            string codigoUsuario = this.repo.GetChat(room);

            ViewBag.CodigoUsuario = codigoUsuario;
            Protectora protectoraSala = this.repo.BuscarProtectora(room);

            return View("Room",protectoraSala);
        }


        /* public static Dictionary<int, string> Rooms = new Dictionary<int, string>()
         {
             { 1,"Cervezas"},
             { 2,"Programacion"},
             { 3,"Moda"}
         };*/

        /*public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {

            return View("Room", room);
        }*/


        
    }
}
