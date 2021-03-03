using System.Threading.Tasks;
using ClassLibraryLivingThings;


namespace Start
{
    class Program
    {
        static async Task Main(string[] args)
        {

           Character.CreateOriginCharacters();
            
           await DifferentMenus.MainMenu();
        }
       
        
       
        
    }
}
