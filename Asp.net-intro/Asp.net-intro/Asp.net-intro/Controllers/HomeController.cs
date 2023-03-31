using Microsoft.AspNetCore.Mvc;

namespace Asp.net_intro.Controllers
{
    public class HomeController : Controller
    {
        //Controller- miras aliriq interface gelsin meselen = IActionResult=istifade edirik View return etsin deye
        //Viewda - html ve c# yazmaq olur
        public IActionResult Index()
        {
            //viewa 2 data gonderende bir Class acib datalari ora qoyub hemin classi gonderirik Viewa
            int[] nums = { 1, 4, 7, 8, 9, 0, 3 };
           
            return View(nums);

        }







        //index-burda actiondur,seyfe acilanda isleyir
      //public string Index(int id)
      //  {
      //      if(id == 0)
      //      {
      //          return "Aqsin";
      //      }
      //      return "Aqsin - " + id;
      //  }

        //public string Detail(string slug,string name)
        //{
        //    return slug + " " + name;
        //}
   
        

        //private string GetName()
        //{
        //    return "Aqsin";
        //}



    }

}
