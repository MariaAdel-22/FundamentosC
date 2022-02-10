using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChat.Models
{
    [Table("CHATS")]
    public class Chats
    {
        [Key]
        [Column("CHAT_COD")]
        public int CodigoChat { get; set; }

        [Column("CODIGO_EMISOR")]
        public string CodigoCuenta { get; set; }

        [Column("CODIGO_RECEPTOR")]
        public string CodigoSala { get; set; }
    }
}
