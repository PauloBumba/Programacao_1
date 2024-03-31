using System;
namespace Ex004{
    namespace models{
        class Program {
            static void Main(){
                // instanciando a class categoria
                categoria categoria1 =new categoria();
                categoria1.Id=1;
                categoria1.tipocategooria=categoria.Tipocategooria.Casa;

                // Instanciando a class localização
                Localizacao localizacao1=new Localizacao();
                localizacao1.Id=1;
                localizacao1.tipoLocalizacao=Localizacao.Tipo_localizacao.Rural;

                //Instanciando a class negocio 

                Negocio negocio1 =new Negocio();
                negocio1.id=1;
                negocio1.tipo_Negocio=Negocio.Tipo_negocio.Locação;

                // Instanciando a class item;

                Itens itens =new Itens();
                itens.Id=1;
                itens.Nome="Mouse";
                itens.Nrode_Comodos=1234;
                itens.Id_categoria=categoria1;
                itens.Descrição="Mouse tipo de sem fio ";
                itens.Valor=230;
                itens.id_localizacao=localizacao1;
                itens.id_negocio=negocio1;

                // Instanciando a Class imagem 
                lista_Imagem lista_Imagem1 =new lista_Imagem();
                lista_Imagem1.imagem=true;
                lista_Imagem1.Nome_do_arquivo="Mouse";
                lista_Imagem1.id_tem=itens;




                // Imprimindo Os produto

                Console.WriteLine($" produto de numero {itens.Id} com o nome {itens.Nome}");



            }
        }
    }
}