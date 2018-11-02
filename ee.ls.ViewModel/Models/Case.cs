using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.ViewModel.Models
{

    /// <summary>
    /// 案件信息
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Case : ICloneable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CaseCode { get; set; }
      

        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
