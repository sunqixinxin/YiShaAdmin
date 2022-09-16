using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.Test;
using YiSha.Model.Param.Test;
using YiSha.Service.Test;

namespace YiSha.Business.Test
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2022-09-15 16:16
    /// 描 述：业务类
    /// </summary>
    public class TestT1BLL
    {
        private TestT1Service testT1Service = new TestT1Service();

        #region 获取数据
        public async Task<TData<List<TestT1Entity>>> GetList(TestT1ListParam param)
        {
            TData<List<TestT1Entity>> obj = new TData<List<TestT1Entity>>();
            obj.Data = await testT1Service.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TestT1Entity>>> GetPageList(TestT1ListParam param, Pagination pagination)
        {
            TData<List<TestT1Entity>> obj = new TData<List<TestT1Entity>>();
            obj.Data = await testT1Service.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TestT1Entity>> GetEntity(long id)
        {
            TData<TestT1Entity> obj = new TData<TestT1Entity>();
            obj.Data = await testT1Service.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TestT1Entity entity)
        {
            TData<string> obj = new TData<string>();
            await testT1Service.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await testT1Service.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
