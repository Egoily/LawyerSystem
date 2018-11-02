using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.ViewModel.Models
{

    /// <summary>
    /// 客户信息
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class Client : ICloneable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public virtual string PhoneNo { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name { get; set; }

        private int _gender;
        /// <summary>
        /// 性别
        /// </summary>
        public virtual int Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                GenderString = GetGender(value);
            }
        }
        public virtual string GenderString { get; set; }


        /// <summary>
        /// 身份证号码
        /// </summary>
        public virtual string IDCardNo { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public virtual string Address { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public static string GetGender(int gender)
        {
            if (gender == 1) return "男";
            else if (gender == 2) return "女";
            else return "未定义";
        }
    }
}
