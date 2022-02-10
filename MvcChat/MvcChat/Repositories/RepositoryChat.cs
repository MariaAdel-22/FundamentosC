using MvcChat.Data;
using MvcChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChat.Repositories
{
    public class RepositoryChat
    {
        private ChatContext context;

        public RepositoryChat(ChatContext context) {

            this.context = context;
        }

        public List<int> GetChats() {

            var consulta = from datos in this.context.Chats select datos.CodigoChat;

            return consulta.ToList();
        }

        public String GetProtectora(int codigoProtectora) {

            var consulta = from datos in this.context.Protectoras where datos.IdProtectora == codigoProtectora select datos.Nombre;

            return consulta.FirstOrDefault();
        }

        public Protectora BuscarProtectora(int codigoProc) {

            var consulta = from datos in this.context.Protectoras where datos.IdProtectora == codigoProc select datos;

            return consulta.FirstOrDefault();
        }

        public string GetChat(int codigoSala) {

            var consulta = from datos in this.context.ChatAll where datos.CodigoSalaChat == codigoSala select datos.CodigoDeCuenta;

            return consulta.FirstOrDefault();
        }
    }
}
