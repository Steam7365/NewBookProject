using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class BookInfo
    {

        public int Id { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        public BookType BookType { get; set; }
        /// <summary>
        /// 书籍类型外键
        /// </summary>
        public int BookTypeID { get; set; }
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
