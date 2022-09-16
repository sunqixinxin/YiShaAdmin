using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.Test;
using YiSha.Business.Test;
using YiSha.Model.Param.Test;

namespace YiSha.Admin.Web.Areas.Test.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2022-09-15 16:16
    /// 描 述：控制器类
    /// </summary>
    [Area("Test")]
    public class TestT1Controller :  BaseController
    {
        private TestT1BLL testT1BLL = new TestT1BLL();

        #region 视图功能
        [AuthorizeFilter("test:testt1:view")]
        public ActionResult TestT1Index()
        {
            return View();
        }

        public ActionResult TestT1Form()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("test:testt1:search")]
        public async Task<ActionResult> GetListJson(TestT1ListParam param)
        {
            TData<List<TestT1Entity>> obj = await testT1BLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("test:testt1:search")]
        public async Task<ActionResult> GetPageListJson(TestT1ListParam param, Pagination pagination)
        {
            TData<List<TestT1Entity>> obj = await testT1BLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TestT1Entity> obj = await testT1BLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("test:testt1:add,test:testt1:edit")]
        public async Task<ActionResult> SaveFormJson(TestT1Entity entity)
        {
            TData<string> obj = await testT1BLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("test:testt1:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await testT1BLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
