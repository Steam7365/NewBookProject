using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class BookType
    {
        public int Id { get; set; } 
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
        public List<BookInfo> BookInfos { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool State { get; set; } = true;
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDel { get; set; } = false;
    }
}
