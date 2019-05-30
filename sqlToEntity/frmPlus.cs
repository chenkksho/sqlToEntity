using sqlToEntity.Base.Control;
using sqlToEntity.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlToEntity
{
    public partial class frmPlus : baseForm
    {
        public frmPlus()
        {
            InitializeComponent();
        }
        private string attrName = "DataMember";
        private string attrTemplate = "[{0} ,Column(Name=\"{1}\")]";
        private string pre = "public";
        private string suffix = "{get; set;}";
        private bool isUpper = true;
        private bool isAllowNull = true;
        private bool isAttr = true;
        private StringBuilder Comment=new StringBuilder();

        
        


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new StringBuilder();
                var sourceStr = this.txtSourceTxt.Text;


                #region 处理注释
                var ss = "Add comments to the columns";
                var sqlField= Regex.Split(sourceStr, ss, RegexOptions.IgnoreCase);
                var tmpStrA = Regex.Split(sqlField[0], "\n(\n", RegexOptions.IgnoreCase);
                #endregion





                var lstSourceField = sourceStr.Split('\n');
                var lstFieldEntity = new List<FieldEntity>();
                foreach (var item in lstSourceField)
                {
                    var entity = new FieldEntity();
                    var tmpStr = new System.Text.RegularExpressions.Regex("[\\s]+").Replace(item, " ");
                    tmpStr = tmpStr.TrimStart(' ').TrimEnd(',');
                    var tmpArr = tmpStr.Split('(')[0].Split(' ');
                    if (isUpper)
                    {
                        entity.FieldName = tmpArr[0].ToUpper();
                    }
                    else
                    {
                        entity.FieldName = tmpArr[0];
                    }

                    entity.FieldType = tmpArr[1];
                    lstFieldEntity.Add(entity);
                }

                CalResult(result, lstFieldEntity);
                this.txtResultTxt.Text = result.ToString();
                this.tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 输出结果
        /// </summary>
        /// <param name="result"></param>
        /// <param name="lstFieldEntity"></param>
        private void CalResult(StringBuilder result, List<FieldEntity> lstFieldEntity)
        {
            foreach (var item in lstFieldEntity)
            {
                if (isAttr)
                {
                    result.AppendLine(string.Format(attrTemplate, attrName, item.FieldName));
                }
                result.AppendLine(string.Format("{0} {1}{4} {2} {3}", pre, exchangeType(item.FieldType.ToUpper()), item.FieldName, suffix, isAllowNull ? "?" : ""));
                result.AppendLine();
            }
        }

        /// <summary>
        /// 转换字段类型
        /// </summary>
        /// <param name="sqlType"></param>
        /// <returns></returns>
        private string exchangeType(string sqlType)
        {
            switch (sqlType)
            {
                case "VARCHAR":
                case "VARCHAR2":
                    return "String";
                case "NUMBER":
                    return "int";
                case "DATE":
                    return "DateTime";
                case "FLOAT":
                    return "decimal";
                default:
                    return "String";
            }
        }



        private void frmPlus_Load(object sender, EventArgs e)
        {
            this.chkIsAllowNull.Checked = this.isAllowNull;
            this.chkIsUpper.Checked = this.isUpper;
            this.chkIsAttr.Checked = this.isAttr;
            Comment.AppendLine(@" /// <summary>
                                   ///{0}
                                   /// </summary>");
        }

        private void chkIsAllowNull_CheckedChanged(object sender, EventArgs e)
        {
            var chkIsAllow = (CheckBox)sender;
            this.isAllowNull = chkIsAllow.Checked;
        }

        private void chkIsUpper_CheckedChanged(object sender, EventArgs e)
        {
            var chkIsUpper = (CheckBox)sender;
            this.isAllowNull = chkIsUpper.Checked;
        }

        private void chkIsAttr_CheckedChanged(object sender, EventArgs e)
        {

            var chkIsAttr = (CheckBox)sender;
            this.isAttr = chkIsAttr.Checked;
        }
    }
}
