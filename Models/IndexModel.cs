using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocumentManagerSample.Models
{
    public class IndexModel
    {
        /// <summary>
        /// 文書カテゴリエンティティ
        /// </summary>
        public Category category { get; set; }

        /// <summary>
        /// 文書カテゴリリスト
        /// </summary>
        public List<Category> lstCategory { get; set; }

        /// <summary>
        /// 登録済文書リスト
        /// </summary>
        public List<Document> lstDocument { get; set; }



        #region constractor

        public IndexModel()
        {
            this.lstCategory = new List<Category>();
        }

        #endregion


        #region private class
        /// <summary>
        /// 文書のカテゴリエンティティ
        /// </summary>
        public class Category
        {
            public string id { get; set; }

            public string categoryName { get; set; }

            public Category(string id, string name)
            {
                this.id = id;
                this.categoryName = name;
            }
        }
        #endregion
    }
}