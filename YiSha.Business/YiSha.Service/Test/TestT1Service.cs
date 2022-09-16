using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.Test;
using YiSha.Model.Param.Test;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YiSha.Service.Test
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2022-09-15 16:16
    /// 描 述：服务类
    /// </summary>
    public class TestT1Service : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TestT1Entity>> GetList(TestT1ListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TestT1Entity>> GetPageList(TestT1ListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<TestT1Entity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<TestT1Entity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(TestT1Entity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                await entity.Modify();
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<TestT1Entity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TestT1Entity, bool>> ListFilter(TestT1ListParam param)
        {
            var expression = LinqExtensions.True<TestT1Entity>();
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.Name))
                {
                    expression = expression.And(t => t.Name.Contains(param.Name));
                }
                if (param.AgeStart > 0)
                {
                    expression = expression.And(t => t.Age >= param.AgeStart);
                }
                if (param.AgeEnd > 0)
                {
                    expression = expression.And(t => t.Age <= param.AgeEnd);
                }

                if (param.Sex >= 0)
                {
                    expression = expression.And(t => t.Sex == (param.Sex > 0));
                }

                if (param.IsEnable >= 0)
                {
                    expression = expression.And(t => t.IsEnale == (param.IsEnable > 0));
                }
            }
            return expression;
        }
        #endregion
    }
}
