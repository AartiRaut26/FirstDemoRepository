using Microsoft.AspNetCore.Mvc;
using TheHighPriestessTarot.Models;

namespace TheHighPriestessTarot.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientsContext _Cc;
        public ClientsController(ClientsContext Db)
        {
            _Cc = Db;
        }
        public IActionResult ClientList()
        {
            try
            {
                //var clnt_List = _Cc.Clients.ToList();

                var clnt_List = from a in _Cc.Clients
                                join b in _Cc.Healing_Dept
                                on a.Healing_Area_Id equals b.Healing_Area_Id
                                into Dept
                                from b in Dept.DefaultIfEmpty()

                                select new Clients
                                {
                                    Client_Id = a.Client_Id,
                                    Client_Name = a.Client_Name,
                                    Client_email = a.Client_email,
                                    Client_Phone = a.Client_Phone,
                                    Client_City = a.Client_City,
                                    Client_State = a.Client_State,
                                    Client_Country = a.Client_Country,
                                    Client_Description = a.Client_Description,
                                    Healing_Area_Id = a.Healing_Area_Id,

                                    Healing_Department_Name = b == null ? "" : b.Healing_Department_Name,
                                };

                return View(clnt_List);

            }
             
            catch(Exception ex)
            {
                return View();

            }
        }
    }
}
