using System;
using System.Data;
namespace Aula008{
    namespace Models{
        class program {
            static void Main(){
                Custemer c1 =new Custemer{CustemerId=1};
                c1.Name="Bumbadas";
                c1.Email_adress="bumbadas@gmail.com";
                Console.WriteLine(c1.CustemerId);
            }

        }
    }
}