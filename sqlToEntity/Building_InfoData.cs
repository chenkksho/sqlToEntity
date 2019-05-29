using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CoolTest.Online.Common.Framework.Attribute;
using CoolTest.Online.Common.Framework.Entity;

namespace CoolTest.Online.Infrastructure.Base.DataContract
{
    /// <summary>
    /// 楼宇信息表
    /// </summary>
    [DataContract Table(Name = "BUILDING_INFO", Description = "")]
    public class Building_InfoData:EntityBase
    {
        #region 字段
        private string _auid;
        private string _building_name = String.Empty;
        private int _area_id;
        private int _city_id;
        private int _province_id;
        private string _area_name = String.Empty;
        private string _city_name = String.Empty;
        private string _province_name = String.Empty;
        private decimal _latitude;
        private decimal _longitude;
        private decimal _map_latitude;
        private decimal _map_longitude;
        private long _grid_id;
        private string _wy_tel = String.Empty;
        private string _wy_person = String.Empty;
        private string _comp_name = String.Empty;
        private string _agent_pesron = String.Empty;
        private string _agent_tel = String.Empty;
        private int _building_type;
        private string _building_use = String.Empty;
        private int _floors;
        private string _building_addr = String.Empty;
        private string _bulider = String.Empty;
        private string _vindicator = String.Empty;
        private DateTime? _last_uptime;
        private string _last_upuser = String.Empty;
        private int _isw_cover;
        private int _isg_cover;
        private string _building_amap = String.Empty;
        private string _building_fmap = String.Empty;
        private string _plan_id = String.Empty;
        private string _psite_period = String.Empty;
        private string _psite_name = String.Empty;
        private string _psite_build_sum = String.Empty;
        private int _building_status;
        private string _desin_factory = String.Empty;
        private string _remark = String.Empty;
        private int _poll_level;
        private string _src_build = String.Empty;
        private string _build_id;
        private string _w_poll_level = String.Empty;
        private DateTime? _imp_date;
        private string _w_in_level = String.Empty;
        private int _w_poll_score;
        private DateTime? _w_in_date;
        private int _is_poll;
        private string _g_poll_level = String.Empty;
        private string _g_in_level = String.Empty;
        private int _g_poll_score;
        private DateTime? _g_in_date;
        private int _w_signal_lev;
        private int _g_signal_lev;
        private int _dev_2gsum;
        private int _dev_3gsum;
        private int _dev_tran_sum;
        private int _dev_sum;
        private decimal? _nodeID;
        private int _is_convert = 0;
        private List<Floors_InfoData> listfloorinfo = new List<Floors_InfoData>();
        //private int istddcover = 0;
        //private string expfddcover;
        //private string exptddcover;
        //private string fddbbs;
        //private string tddbbs;

        public Building_InfoData()
        {
            IsfddCover = 0;
        }

        #endregion

        #region 属性
        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Auid")]
        public string Auid
        {
            get { return _auid; }
            set { _auid = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Name")]
        public string Building_Name
        {
            get { return _building_name; }
            set { _building_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Area_Id")]
        public int Area_Id
        {
            get { return _area_id; }
            set { _area_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "City_Id")]
        public int City_Id
        {
            get { return _city_id; }
            set { _city_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Province_Id")]
        public int Province_Id
        {
            get { return _province_id; }
            set { _province_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Area_Name")]
        public string Area_Name
        {
            get { return _area_name; }
            set { _area_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "City_Name")]
        public string City_Name
        {
            get { return _city_name; }
            set { _city_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Province_Name")]
        public string Province_Name
        {
            get { return _province_name; }
            set { _province_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Latitude")]
        public decimal Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Longitude")]
        public decimal Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Map_Latitude")]
        public decimal Map_Latitude
        {
            get { return _map_latitude; }
            set { _map_latitude = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Map_Longitude")]
        public decimal Map_Longitude
        {
            get { return _map_longitude; }
            set { _map_longitude = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Grid_Id")]
        public long Grid_Id
        {
            get { return _grid_id; }
            set { _grid_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Wy_Tel")]
        public string Wy_Tel
        {
            get { return _wy_tel; }
            set { _wy_tel = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Wy_Person")]
        public string Wy_Person
        {
            get { return _wy_person; }
            set { _wy_person = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Comp_Name")]
        public string Comp_Name
        {
            get { return _comp_name; }
            set { _comp_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Agent_Pesron")]
        public string Agent_Pesron
        {
            get { return _agent_pesron; }
            set { _agent_pesron = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Agent_Tel")]
        public string Agent_Tel
        {
            get { return _agent_tel; }
            set { _agent_tel = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Type")]
        public int Building_Type
        {
            get { return _building_type; }
            set { _building_type = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Use")]
        public string Building_Use
        {
            get { return _building_use; }
            set { _building_use = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Floors")]
        public int Floors
        {
            get { return _floors; }
            set { _floors = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Addr")]
        public string Building_Addr
        {
            get { return _building_addr; }
            set { _building_addr = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Bulider")]
        public string Bulider
        {
            get { return _bulider; }
            set { _bulider = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Vindicator")]
        public string Vindicator
        {
            get { return _vindicator; }
            set { _vindicator = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Last_Uptime")]
        public DateTime? Last_Uptime
        {
            get { return _last_uptime; }
            set { _last_uptime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Last_Upuser")]
        public string Last_Upuser
        {
            get { return _last_upuser; }
            set { _last_upuser = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Isw_Cover")]
        public int Isw_Cover
        {
            get { return _isw_cover; }
            set { _isw_cover = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Isg_Cover")]
        public int Isg_Cover
        {
            get { return _isg_cover; }
            set { _isg_cover = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Amap")]
        public string Building_Amap
        {
            get { return _building_amap; }
            set { _building_amap = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Fmap")]
        public string Building_Fmap
        {
            get { return _building_fmap; }
            set { _building_fmap = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Plan_Id")]
        public string Plan_Id
        {
            get { return _plan_id; }
            set { _plan_id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Psite_Period")]
        public string Psite_Period
        {
            get { return _psite_period; }
            set { _psite_period = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Psite_Name")]
        public string Psite_Name
        {
            get { return _psite_name; }
            set { _psite_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Psite_Build_Sum")]
        public string Psite_Build_Sum
        {
            get { return _psite_build_sum; }
            set { _psite_build_sum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Status")]
        public int Building_Status
        {
            get { return _building_status; }
            set { _building_status = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_Status_Name")]
        public string Building_Status_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_GsmSignalLevel")]
        public string Building_GsmSignalLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Building_WcdmaSignalLevel")]
        public string Building_WcdmaSignalLevel { get; set; }


        /// <summary>
        /// 楼宇类型中文名
        /// </summary>
        [DataMember Column(Name = "Building_Type_Name")]
        public string Building_Type_Name { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Desin_Factory")]
        public string Desin_Factory
        {
            get { return _desin_factory; }
            set { _desin_factory = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "Remark")]
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// 巡检等级，运维部门定义的等级
        /// </summary>
        [DataMember Column(Name = "Poll_Level")]
        public int Poll_Level
        {
            get { return _poll_level; }
            set { _poll_level = value; }
        }

        /// <summary>
        /// 楼宇编号(原楼宇系统）
        /// </summary>
        [DataMember Column(Name = "Src_Build")]
        public string Src_Build
        {
            get { return _src_build; }
            set { _src_build = value; }
        }

        /// <summary>
        /// 楼宇新编码
        /// </summary>
        [DataMember Column(Name = "Build_Id")]
        public string Build_Id
        {
            get { return _build_id; }
            set { _build_id = value; }
        }

        /// <summary>
        /// 楼宇巡检WCDMA质量等级字符，填写：优、良、入网、差
        /// </summary>
        [DataMember Column(Name = "W_Poll_Level")]
        public string W_Poll_Level
        {
            get { return _w_poll_level; }
            set { _w_poll_level = value; }
        }

        /// <summary>
        /// 楼宇导入时间时间。系统自动生成，用户无需填写
        /// </summary>
        [DataMember Column(Name = "Imp_Date")]
        public DateTime? Imp_Date
        {
            get { return _imp_date; }
            set { _imp_date = value; }
        }

        /// <summary>
        /// 楼宇WCDMA入网等级字符，填写：优、良、入网

        /// </summary>
        [DataMember Column(Name = "W_In_Level")]
        public string W_In_Level
        {
            get { return _w_in_level; }
            set { _w_in_level = value; }
        }

        /// <summary>
        /// 楼宇巡检WCDMA综合打分数字。系统自动生成，用户无需填写
        /// </summary>
        [DataMember Column(Name = "W_Poll_Score")]
        public int W_Poll_Score
        {
            get { return _w_poll_score; }
            set { _w_poll_score = value; }
        }

        /// <summary>
        /// 楼宇WCDMA入网时间
        /// </summary>
        [DataMember Column(Name = "W_In_Date")]
        public DateTime? W_In_Date
        {
            get { return _w_in_date; }
            set { _w_in_date = value; }
        }

        /// <summary>
        /// 楼宇是否巡检字符。填写：阿拉伯数字1或0。1对应巡检，0对应不巡检。
        /// </summary>
        [DataMember Column(Name = "Is_Poll")]
        public int Is_Poll
        {
            get { return _is_poll; }
            set { _is_poll = value; }
        }

        /// <summary>
        /// 楼宇巡检GSM质量等级字符，填写：优、良、入网、差
        /// </summary>
        [DataMember Column(Name = "G_Poll_Level")]
        public string G_Poll_Level
        {
            get { return _g_poll_level; }
            set { _g_poll_level = value; }
        }

        /// <summary>
        /// 楼宇GSM入网等级字符，填写：优、良、入网

        /// </summary>
        [DataMember Column(Name = "G_In_Level")]
        public string G_In_Level
        {
            get { return _g_in_level; }
            set { _g_in_level = value; }
        }

        /// <summary>
        /// 楼宇巡检GSM综合打分数字。系统自动生成，用户无需填写
        /// </summary>
        [DataMember Column(Name = "G_Poll_Score")]
        public int G_Poll_Score
        {
            get { return _g_poll_score; }
            set { _g_poll_score = value; }
        }

        /// <summary>
        /// 楼宇GSM入网时间
        /// </summary>
        [DataMember Column(Name = "G_In_Date")]
        public DateTime? G_In_Date
        {
            get { return _g_in_date; }
            set { _g_in_date = value; }
        }

        /// <summary>
        /// WCDMA信源分级数字。必须填写以下4个数字之一：1、VIP，2、A类，3、B类，4、C类。(必填)
        /// </summary>
        [DataMember Column(Name = "W_Signal_Lev")]
        public int W_Signal_Lev
        {
            get { return _w_signal_lev; }
            set { _w_signal_lev = value; }
        }

        /// <summary>
        /// GSM信源分级数字。必须填写以下4个数字之一：1、VIP，2、A类，3、B类，4、C类。(必填)
        /// </summary>
        [DataMember Column(Name = "G_Signal_Lev")]
        public int G_Signal_Lev
        {
            get { return _g_signal_lev; }
            set { _g_signal_lev = value; }
        }

        /// <summary>
        /// 2G有源设备数量
        /// </summary>
        [DataMember Column(Name = "Dev_2gsum")]
        public int Dev_2gsum
        {
            get { return _dev_2gsum; }
            set { _dev_2gsum = value; }
        }

        /// <summary>
        /// 3G有源设备数量
        /// </summary>
        [DataMember Column(Name = "Dev_3gsum")]
        public int Dev_3gsum
        {
            get { return _dev_3gsum; }
            set { _dev_3gsum = value; }
        }

        /// <summary>
        /// 传输设备数量
        /// </summary>
        [DataMember Column(Name = "Dev_Tran_Sum")]
        public int Dev_Tran_Sum
        {
            get { return _dev_tran_sum; }
            set { _dev_tran_sum = value; }
        }

        /// <summary>
        /// 有源设备数量合计
        /// </summary>
        [DataMember Column(Name = "Dev_Sum")]
        public int Dev_Sum
        {
            get { return _dev_sum; }
            set { _dev_sum = value; }
        }
        [DataMember Column(Name = "GsmSiteCellBuildingUnionId")]
        public string GsmSiteCellBuildingUnionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "GsmSiteCellBuildingUnion")]
        public string GsmSiteCellBuildingUnion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "WcdmaSiteCellBuildingUnion")]
        public string WcdmaSiteCellBuildingUnion { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "W_Is_Ctrl")]
        public int W_Is_Ctrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "G_Is_Ctrl")]
        public int G_Is_Ctrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "W_WsnUniCom")]
        public string W_WsnUniCom { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "W_Wsn")]
        public string W_Wsn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "W_Bbs")]
        public string W_Bbs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "W_Site_Id")]
        public string W_Site_Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "W_Rf")]
        public string W_Rf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "G_Wsn")]
        public string G_Wsn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "G_WsnUnicom")]
        public string G_WsnUnicom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "G_Bts")]
        public string G_Bts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "G_Site_Id")]
        public string G_Site_Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember Column(Name = "G_Rf")]
        public string G_Rf { get; set; }

        [DataMember Column(Name = "FmapNodeID")]
        public decimal? FmapNodeID { get; set; }

        [DataMember Column(Name = "AmapNodeID")]
        public decimal? AmapNodeID { get; set; }
        /// <summary>
        /// /TDD信源/施主基站站名字符，多个站名之间以“；”号分隔
        /// </summary>
        [DataMember Column(Name = "TDD_Bts")]
        public string TDD_Bts { get; set; }
        /// <summary>
        /// TDD入网时间
        /// </summary>
        [DataMember Column(Name = "TDD_IN_DATE")]
        public DateTime? TDD_IN_DATE { get; set; }
        /// <summary>
        /// TDD入网等级
        /// </summary>
        [DataMember Column(Name = "TDD_IN_LEVEL")]
        public string TDD_IN_LEVEL { get; set; }
        /// <summary>
        /// TDD是否经建设管控流程
        /// </summary>
        [DataMember Column(Name = "TDD_IS_CTRL")]
        public int TDD_IS_CTRL { get; set; }
        /// <summary>
        /// 巡检TDD-LTE质量等级
        /// </summary>
        [DataMember Column(Name = "TDD_POLL_LEVEL")]
        public string TDD_POLL_LEVEL { get; set; }
        /// <summary>
        /// 巡检TDD综合打分
        /// </summary>
        [DataMember Column(Name = "TDD_POLL_SCORE")]
        public int TDD_POLL_SCORE { get; set; }
        /// <summary>
        /// TDD信源射频单元型号
        /// </summary>
        [DataMember Column(Name = "TDD_RF")]
        public string TDD_RF { get; set; }
        /// <summary>
        /// TDD信源分级
        /// </summary>
        [DataMember Column(Name = "TDD_SIGNAL_LEV")]
        public int TDD_SIGNAL_LEV { get; set; }
        /// <summary>
        /// TDD信源/施主基站型号
        /// </summary>
        [DataMember Column(Name = "TDD_SITE_ID")]
        public string TDD_SITE_ID { get; set; }
        /// <summary>
        /// TDD室分编号
        /// </summary>
        [DataMember Column(Name = "TDD_WSN")]
        public string TDD_WSN { get; set; }
        /// <summary>
        /// FDD信源/施主基站站名字符，多个站名之间以“；”号分隔
        /// </summary>
        [DataMember Column(Name = "FDD_BTS")]
        public string FDD_BTS { get; set; }
        /// <summary>
        /// FDD入网时间
        /// </summary>
        [DataMember Column(Name = "FDD_IN_DATE")]
        public DateTime? FDD_IN_DATE { get; set; }
        /// <summary>
        /// FDD入网等级
        /// </summary>
        [DataMember Column(Name = "FDD_IN_LEVEL")]
        public string FDD_IN_LEVEL { get; set; }
        /// <summary>
        /// FDD是否经建设管控流程
        /// </summary>
        [DataMember Column(Name = "FDD_IS_CTRL")]
        public int FDD_IS_CTRL { get; set; }
        /// <summary>
        /// 巡检FDD-LTE质量等级
        /// </summary>
        [DataMember Column(Name = "FDD_POLL_LEVEL")]
        public string FDD_POLL_LEVEL { get; set; }
        /// <summary>
        /// 巡检FDD综合打分
        /// </summary>

        [DataMember Column(Name = "FDD_POLL_SCORE")]
        public int FDD_POLL_SCORE { get; set; }
        /// <summary>
        /// FDD信源射频单元型号
        /// </summary>
        [DataMember Column(Name = "FDD_RF")]
        public string FDD_RF { get; set; }
        /// <summary>
        /// FDD信源分级
        /// </summary>
        [DataMember Column(Name = "FDD_SIGNAL_LEV")]
        public int FDD_SIGNAL_LEV { get; set; }
        /// <summary>
        /// FDD信源/施主基站型号
        /// </summary>
        [DataMember Column(Name = "FDD_SITE_ID")]
        public string FDD_SITE_ID { get; set; }
        /// <summary>
        /// FDD室分编号
        /// </summary>
        [DataMember Column(Name = "FDD_WSN")]
        public string FDD_WSN { get; set; }
        /// <summary>
        /// FDD-LTE室分覆盖
        /// </summary>
        [DataMember Column(Name = "ISF_COVER")]
        public int ISF_COVER { get; set; }
        /// <summary>
        /// TDD-LTE室分覆盖
        /// </summary>
        [DataMember Column(Name = "IST_COVER")]
        public int IST_COVER { get; set; }
        /// <summary>
        /// 4G有源设备数量
        /// </summary>
        [DataMember Column(Name = "DEV_4GSUM")]
        public int DEV_4GSUM { get; set; }

        [DataMember Column(Name = "TddSiteCellBuildingUnion")]
        public string TddSiteCellBuildingUnion { get; set; }


        [DataMember Column(Name = "FddSiteCellBuildingUnion")]
        public string FddSiteCellBuildingUnion { get; set; }


        [DataMember Column(Name = "Net_Type")]
        public string Net_Type { get; set; }


        [DataMember Column(Name = "SsMarketGrid")]
        public string SsMarketGrid
        {
            get;
            set;
        }
        [DataMember Column(Name = "BuildIdunicom")]
        public string BuildIdunicom
        {
            get;
            set;
        }

        #region 一二级融合
        [DataMember Column(Name = "ActOnFloorCnt")]
        public int ActOnFloorCnt { get; set; }


        [DataMember Column(Name = "ActUnderFloorCnt")]
        public int ActUnderFloorCnt { get; set; }


        [DataMember Column(Name = "ActUnderParkCnt")]
        public int ActUnderParkCnt { get; set; }


        [DataMember Column(Name = "ActElevatorCnt")]
        public int ActElevatorCnt { get; set; }


        [DataMember Column(Name = "PollCid")]
        public string PollCid { get; set; }


        [DataMember Column(Name = "WCarrierCnt")]
        public int WCarrierCnt { get; set; }


        [DataMember Column(Name = "GCarrierCnt")]
        public int GCarrierCnt { get; set; }


        [DataMember Column(Name = "TopolGraph")]
        public string TopolGraph { get; set; }


        [DataMember Column(Name = "TopolGraphNodeID")]
        public decimal? TopolGraphNodeID { get; set; }


        [DataMember Column(Name = "ExpOnFloorCnt")]
        public int ExpOnFloorCnt { get; set; }


        [DataMember Column(Name = "ExpUnderFloorCnt")]
        public int ExpUnderFloorCnt { get; set; }


        [DataMember Column(Name = "ExpUnderParkCnt")]
        public int ExpUnderParkCnt { get; set; }


        [DataMember Column(Name = "ExpElevatorCnt")]
        public int ExpElevatorCnt { get; set; }


        [DataMember Column(Name = "SysProject")]
        public string SysProject { get; set; }


        [DataMember Column(Name = "SysProjectNum")]
        public string SysProjectNum { get; set; }


        [DataMember Column(Name = "DesignRequire")]
        public string DesignRequire { get; set; }



        [DataMember Column(Name = "JtAreaName")]
        public string JtAreaName { get; set; }


        [DataMember Column(Name = "JtCityName")]
        public string JtCityName { get; set; }


        [DataMember]
        public string ExpWCover { get; set; }


        [DataMember ]
        public string ActWCover { get; set; }


        [DataMember Column(Name = "ExpGCover")]
        public string ExpGCover { get; set; }


        [DataMember ]
        public string ActGCover { get; set; }


        #endregion
        #region 所属分公司
        [DataMember Column(Name = "Branch")]
        public string Branch { get; set; }
        #endregion
        #endregion

        /// <summary>
        /// 是否需要更新数据到集团
        /// </summary>
        [DataMember ]
        public decimal? NeedSyncData { get; set; }

        /// <summary>
        /// 是否切换外泄测试
        /// </summary>
        [DataMember]
        public int IsConvertTest { get; set; }


        [DataMember ]
        public int IsfddCover { get; set; }


        [DataMember]
        public int IstddCover { get; set; }


        [DataMember]
        public string ExpTddCover { get; set; }


        [DataMember ]
        public string ExpFddCover { get; set; }


        [DataMember ]
        public string FddBbs { get; set; }

        [DataMember ]
        public string TddBbs { get; set; }

        [DataMember ]
        public DateTime? CreateDateTime { get; set; }


        [DataMember ]
        public int OperationCompany { get; set; }

        [DataMember ]
        public int IstdscdmaCover { get; set; }

        [DataMember ]
        public string TdscdmaWsn { get; set; }

        [DataMember ]
        public string TdscdmaBbs { get; set; }


        [DataMember]
        public int IscdmaCover { get; set; }

        [DataMember ]
        public string CdmaWsn { get; set; }

        [DataMember Column(Name = "CDMA_BBS")]
        public string CDMA_BBS { get; set; }


        [DataMember ]
        public int IscdmaevCover { get; set; }

        [DataMember ]
        public string CdmaevWsn { get; set; }

        [DataMember ]
        public string CdmaevBbs { get; set; }

        [DataMember ]
        public int GSMStatus { get; set; }//GSM楼宇状态

        [DataMember ]
        public int WCDMAStatus { get; set; }//WCDMA楼宇状态

        [DataMember]
        public int TDDStatus { get; set; }//TDD楼宇状态

        [DataMember]
        public int FDDStatus { get; set; }//FDD楼宇状态

        [DataMember]
        public string GSMStatusName { get; set; }//GSM楼宇状态名称

        [DataMember ]
        public string WCDMAStatusName { get; set; }//WCDMA楼宇状态名称

        [DataMember ]
        public string TDDStatusName { get; set; }//TDD楼宇状态名称

        [DataMember]
        public string FDDStatusName { get; set; }//FDD楼宇状态名称

        [DataMember]
        public int ISAdd { get; set; }//是否新增

        [DataMember]
        public List<Floors_InfoData> listFloorInfo
        {
            get
            {
                return listfloorinfo;
            }
            set
            {
                listfloorinfo = value;
            }
        }//楼宇池导入的时候用到
        #region 山西
        [DataMember Column(Name = "TieTaBuild")]
        public int TieTaBuild { get; set; }

        [DataMember Column(Name = "InDoorDesc")]
        public string InDoorDesc { get; set; }

        /// <summary>
        /// 设计覆盖楼宇数
        /// </summary>
        [DataMember]
        public int DesignOverlayCount { get; set; }
        #endregion

        /// <summary>
        ///所属网络
        /// </summary>
        [DataMember Column(Name = "BELONG_GRID")]
        public string BELONG_GRID { get; set; }
        /// <summary>
        ///网格类型
        /// </summary>
        [DataMember Column(Name = "GRID_TYPE")]
        public int GRID_TYPE { get; set; }
        /// <summary>
        ///沃优栅格编码
        /// </summary>
        [DataMember Column(Name = "VOYO_GRID")]
        public string VOYO_GRID { get; set; }
        /// <summary>
        ///微网格类型
        /// </summary>
        [DataMember Column(Name = "V_GRID_TYPE")]
        public int V_GRID_TYPE { get; set; }
        /// <summary>
        ///楼宇结构(开放式;半开放式;密闭式)
        /// </summary>
        [DataMember Column(Name = "BUILDING_STRUCTURE")]
        public int BUILDING_STRUCTURE { get; set; }
        /// <summary>
        ///楼宇重要性(I类楼宇;II类楼宇;III类楼宇)
        /// </summary>
        [DataMember Column(Name = "BUILDING_IMPORTANCE")]
        public int BUILDING_IMPORTANCE { get; set; }
        /// <summary>
        ///移动是否有室分(是;否)
        /// </summary>
        [DataMember Column(Name = "MOBILE_CELL")]
        public int MOBILE_CELL { get; set; }
        /// <summary>
        ///电信是否有室分(是;否)
        /// </summary>
        [DataMember Column(Name = "TELECOM_CELL")]
        public int TELECOM_CELL { get; set; }
        /// <summary>
        ///楼宇类型  住宅楼;低层连片住宅;写字楼;办公楼;宿舍楼;宾馆酒店;商场;交通枢纽建筑;公共建筑;综合体建筑;低层连片商业建筑
        /// </summary>
        [DataMember Column(Name = "BUILDING_CLASS")]
        public int BUILDING_CLASS { get; set; }
        /// <summary>
        ///云天原始记录id
        /// </summary>
        [DataMember Column(Name = "YT_AUID")]
        public string YT_AUID { get; set; }
        /// <summary>
        ///楼宇分类 A类;B类;住宅
        /// </summary>
        [DataMember Column(Name = "BUILDING_PROP")]
        public int BUILDING_PROP { get; set; }
    }
}