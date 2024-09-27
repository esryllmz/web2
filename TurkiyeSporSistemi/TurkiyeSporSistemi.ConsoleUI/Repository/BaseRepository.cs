using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Models;

namespace TurkiyeSporSistemi.ConsoleUI.Repository
{
    public static class BaseRepository
    {
       
        public static List<Team> Teams = new List<Team>()
        {
            new Team()
            {
                Id=Guid.NewGuid(),
                Name="TRABZONSPOR",
                Description="Trabzonspor Açıklaması",
                Since=new DateTime(1967,1,4)
            },

               new Team()
            {
                Id=Guid.NewGuid(),
                Name="fenerbahçe",
                Description="Şikebahçe",
                Since=new DateTime(1907,7,7)
            }
        };

        public static List<Player> Players = new List<Player>()
        {
            new Player()
            {
                Id=1,
                Name="Okay",
                Surname="Yokuşlu",
                Branch="Futbol",
                Number="5",
                MarketValue=1000000,
                Position="Defansif Orta Saha",
                TeamId=new Guid("{186F817D-2040-4BDA-895C-33584C563D21}")


            },

            new Player()
            {

                Id =2,
                Name="Atilla",
                Surname="Karaoğlan",
                Branch= "Futbol",
                MarketValue=100000,
                Number="99", 
                Position="Forvet",
                TeamId=new Guid("{7B0A9004-1AE3-487C-8555-4890BFC4E5F0}")



            }
        };
    }
}
