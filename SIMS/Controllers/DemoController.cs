using Microsoft.AspNetCore.Mvc;

namespace SIMS.Controllers
{
    public class DemoController : LoginController
    {
        public string HelloWorld()
        {
            return "Hello word - SE08203 - APDP";
            // thay dc : "Hello word - SE08203 - APDP" ngoai trinh duyet
            // https://localhost:7110/
            // https : protocol : giao thuc
            // localhost : ten mien(domain) dai dien cho dia chi ip : 127.0.0.1
            // 7710 : port - cong giao tiep
            // https://localhost:7110/Demo/HelloWorld
            // Demo : Ten cua controller
            // HelloWorld : ten cua method(ham) trong controller.
        }
        public string Product(int id, string name, float price)
        {
            return $"Product - Apple | id : {id} - name : {name} - price : {price}";
            // https://localhost:7110/Demo/Product?id=10&name=Iphone&price=3000
        }
    }
}
