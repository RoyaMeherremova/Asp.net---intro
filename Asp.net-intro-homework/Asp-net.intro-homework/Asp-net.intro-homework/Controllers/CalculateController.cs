using Microsoft.AspNetCore.Mvc;
using System;

namespace Asp_net.intro_homework.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            //3) Calculate controllerin index action-da fibonacci algoritmasinin cavabini tapib view - a gondermek ve h1 - tagi icerisinde gostermek.

            int a = 0;
            int b = 1;
            int c;
            int[] fibNums = new int[10];
            fibNums[0] = a;
            fibNums[1] = b;
            for (int i = 2; i < fibNums.Length; i++)
            {
                c = a + b; //c=0+1 =1 //c=1+1=2 // c = 2+1=3 //c =3+2
                a = b;     // 1   1   2  3
                b = c;     //1   2   3   5
                fibNums[i] = c;
            }

            return View(fibNums);
        }
    }
}
