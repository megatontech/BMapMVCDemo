using System.Web.Mvc;
using System.Collections.Generic;
namespace BMapMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 查询后台数据
        /// </summary>
        /// <returns></returns>
        public JsonResult JsonAllDeviceView() 
        {
            List<Device> devList = new List<Device>();
            for (int count = 0; count < 100;count++ )
            {
                Device dev = new Device();
                dev.deviceName = "Megaton";
                dev.errorLevel =GetRanNumber(0,5);
                dev.x = GetRanNumber(-150,150);
                dev.y = GetRanNumber(-70,70);
                devList.Add(dev);
            }
            return Json(devList, JsonRequestBehavior.AllowGet);
        }
        public int GetRanNumber(int start, int end) 
        {
            var seed = System.Guid.NewGuid().GetHashCode();
            var random = new System.Random(seed);
            int result = 0;
            result = random.Next(start, end);
            return result;
        }
    }
    public　class Device
    {
        public int x { get; set; }
        public int y { get; set; }
        public int errorLevel { get; set; }
        public string deviceName { get; set; }
    }
}