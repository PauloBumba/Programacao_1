using System;
namespace Ex004.Dados{
    class Program {
        static void Main(){
            Imoveis Imv =new Imoveis();

            Imv.Name="Celular";
            Imv.Number_of=1;
            Imv.Describe="Memoria Ram de 8gb e Rom de 254gb  um ano garantir versão 17.2.1";
            Imv.Localidade=Imoveis.Tipo_de_localidade.Urbano;
            Imv.Negocio=Imoveis.Tipo_de_negocio.Locação;
            

            Console.WriteLine($" Nome : {Imv.Name}");
            Console.WriteLine($" Numero de itens : {Imv.Number_of}");
            Console.WriteLine($" Localidade : {Imv.Localidade}");
            Console.WriteLine($" Negocio : {Imv.Negocio}");
            Console.WriteLine($"Describe do Produto : {Imv.Describe}");
            

            Categoria ctg=new Categoria();
            ctg.Apartamentos=true;
            ctg.Casas=false;
            ctg.Sitios=false;
            
            Imv.categorias.Add(ctg);
            Console.WriteLine(ctg.Apartamentos);
            foreach (var print in Imv.categorias   ){
                Console.WriteLine(print.Apartamentos);
            }

        }
    }
}