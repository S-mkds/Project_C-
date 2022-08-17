using System;

namespace Project_Neovendis// Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello and welcome to this XIMITI store!");

            // Direction Product SensId

            string first_direction = "H x L x P";
            string second_direction = "L x H x P";
            string third_direction = "P x L x H";
            string fourth_direction = "P x H x L";
            string fifth_direction = "H x P x L";
            string sixth_direction = "L x P x H";


            // Product List StoreItemId

            //String id_ =	" " + " D: , H: , W: ";

            String id_205 = "NUTELLA VERRE 200G " + " D: 79, H: 90, W: 79";
            String id_207 = "SUNDY BARRE 36G " + " D: 133, H: 25, W: 40";
            String id_214 = "MONSTER ENERGY VERT 50CL " + " D: 65, H: 170, W: 65";
            String id_215 = "MONSTER ENERGY RIPPER 50CL " + " D: 65, H:	170, W: 65";
            String id_216 = "KIT KAT CHUNKY WHITE 40G " + " D: 145, H: 20, W: 33";
            String id_222 = "HARIBO WORLD MIX 120G " + " D: 150, H:	30, W: 132";
            String id_236 = "COCA ZÉRO 1.5L " + " D: 91, H:	320, W:	91";
            String id_249 = "SDW CLUB PAIN COMPLET ROSETTE 130G SODEBO " + " D:	135, H: 140, W:	75";
            String id_251 = "SDW CLUB PAIN COMPLET THON CRUDITÉS 140G SODEBO " + " D: 135, H: 140, W: 75";
            String id_252 = "GRANOLA COOKIES PÉPITES CHOCOLAT 184G " + " D:	110, H: 40, W: 195";
            String id_257 = "CONFITURE FRAISE 360G CO " + " D: 90, H: 100, W: 90";
            String id_260 = "NUTELLA & GO 52G " + " D: 42, H: 80, W: 85";
            String id_261 = "TIC TAC DUO 18G " + " D: 64, H: 16, W: 40";
            String id_262 = "TIC TAC MENTHE 18G " + " D: 64, H: 16, W: 40";
            String id_265 = "CACOLAC 25CL " + " D: 52, H: 135, W: 52";
            String id_268 = "HOLLYWOOD DRAGÉE FRAISE DES BOIS X20 28G " + " D: 78, H: 18, W: 46";
            String id_269 = "HARIBO HAPPY COLA 120G " + " D: 155, H: 25, W: 110";
            String id_270 = "CRÈME DESSERT VANILLE 4x125G ELLE&VIRE " + " D: 165,H: 45, W: 145";
            String id_278 = "CRISTALINE 1.5L " + " D: 87, H: 310, W: 87";
            String id_281 = "SDW CLUB PAIN COMPLET JAMBON EMMENTAL 145G SODEBO " + " D:	125, H: 140, W:	75";
            String id_287 = "CURLY CACAHUÈTE LORENZ 100G " + " D: 175, H: 35, W: 145";
            String id_292 = "DANAO PÊCHE ABRICOT 1L " + " D: 77, H:233, W: 77";
            String id_293 = "OASIS PÊCHE ABRICOT 33CL " + " D: 66, H: 115, W: 66";
            String id_295 = "JUS D'ORANGE DE FLORIDE 100% PUR JUS 1L CO " + " D: 70, H: 235, W: 70";
            String id_302 = "MINUTE MAID POMME 33CL " + " D: 66, H: 115, W: 66";
            String id_306 = "OASIS POMME POIRE 33CL " + " D: 66, H, 115, W: 66";

            /* « ½ baguette précuite » avec dimensions H=40mm, L=180mm et P= 350mm doit être placé dans le sens 1.
             Dans un autre sens le produit tomberait et/ou occuperait beaucoup de place dans le rayon.  
             Autre exemple : une canette ne pas être positionnée « couchée » car elle roulerait lors du mouvement.
            */

            try
            {
                Console.WriteLine("Le produit id_205 " + id_205 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_207 " + id_207 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_214 " + id_214 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_215 " + id_215 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_216 " + id_216 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_222 " + id_222 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_236 " + id_236 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_249 " + id_249 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_251 " + id_251 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_252 " + id_252 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_257 " + id_257 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_260 " + id_260 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_261 " + id_261 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_262 " + id_262 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_265 " + id_265 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_268 " + id_268 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_269 " + id_269 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_270 " + id_270 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_278 " + id_278 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_281 " + id_281 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_287 " + id_287 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_292 " + id_292 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_293 " + id_293 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_295 " + id_295 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_302 " + id_302 + " doit être placé dans le sens " + first_direction);
                Console.WriteLine("Le produit id_306 " + id_306 + " doit être placé dans le sens " + first_direction);

            }
            catch
            {
                Console.WriteLine("an error occurred");
                return;
            }
        }
    }
}