﻿using gip.core.datamodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kse.mes.processapplication
{
    [ACSerializeableInfo]
    [ACClassInfo(Const.PackName_VarioAutomation, "en{'ADMB_VariousEquipmentsAlarm'}de{'ADMB_VariousEquipmentsAlarm'}", Global.ACKinds.TACEnum)]
    public enum ADMB_VariousEquipmentsAlarm : short
    {
        ConfigAlarm = -9999,
        None = 0,
        Reserved_0001 = 1,
        Reserved_0002 = 2,
        Reserved_0003 = 3,
        Reserved_0004 = 4,
        InterruptedForFencingAccess = 5,
        Reserved_0006 = 6,
        Reserved_0007 = 7,
        Reserved_0008 = 8,
        Reserved_0009 = 9,
        Reserved_0010 = 10,
        DustExhaustModuleAlarm = 101,
        Reserved_0102 = 102,
        AirPressureControlModuleAlarm = 201,
        Reserved_0202 = 202,
        Reserved_0203 = 203,
        Reserved_0204 = 204,
        Reserved_0205 = 205,
        PositioningModuleAlarm = 301,
        NoReleasePositioningWeigher = 302,
        WeigherPositionWasLost = 303,
        Reserved_0401 = 401,
        Reserved_0402 = 402,
        Reserved_0403 = 403,
        Reserved_0404 = 404,
        Reserved_0405 = 405,
        Reserved_0406 = 406,
        Reserved_0407 = 407,
        Reserved_0408 = 408,
        Reserved_0409 = 409,
        Reserved_0410 = 410,
        VibratorModuleAlarm = 501,
        Reserved_0502 = 502,
        Reserved_0503 = 503,
        Reserved_0504 = 504,
        PusherModuleAlarm = 601,
        Reserved_0602 = 602,
        Reserved_0603 = 603,
        Reserved_0604 = 604,
        VibratorOnDischargeSealModuleAlarm = 701,
        Reserved_0702 = 702,
        Reserved_0703 = 703,
        Reserved_0704 = 704,
        Reserved_0801 = 801,
        Reserved_0802 = 802,
        Reserved_0803 = 803,
        Reserved_0804 = 804,
        WeightSignalW1NotValid = 805,
        WeightSignalW2NotValid = 806,
        PressureSignalNotValid = 807,
        Reserved_0808 = 808,
        Reserved_0809 = 809,
        Reserved_0810 = 810,
        Reserved_0901 = 901,
        Reserved_0902 = 902,
        Reserved_0903 = 903,
        Reserved_0904 = 904,
        Reserved_0905 = 905,
        Reserved_0906 = 906,
        Reserved_0907 = 907,
        Reserved_0908 = 908,
        Reserved_0909 = 909,
        Reserved_0910 = 910,
        Reserved_0911 = 911,
        Reserved_0912 = 912,
        Reserved_0913 = 913,
        Reserved_0914 = 914,
        Reserved_0915 = 915,
        Reserved_0916 = 916,
        Reserved_0917 = 917,
        Reserved_0918 = 918,
        Reserved_0919 = 919,
        Reserved_0920 = 920,
        Reserved_0921 = 921,
        Reserved_0922 = 922,
        Reserved_0923 = 923,
        Reserved_0924 = 924,
        Reserved_0925 = 925,
        Reserved_0926 = 926,
        Reserved_0927 = 927,
        Reserved_0928 = 928,
        Reserved_0929 = 929,
        Reserved_0930 = 930,
        Reserved_0931 = 931,
        Reserved_0932 = 932,
        Reserved_0933 = 933,
        Reserved_0934 = 934,
        Reserved_0935 = 935,
        Reserved_0936 = 936,
        Reserved_0937 = 937,
        Reserved_0938 = 938,
        Reserved_0939 = 939,
        Reserved_0940 = 940,
        Reserved_0941 = 941,
        Reserved_0942 = 942,
        Reserved_0943 = 943,
        Reserved_0944 = 944,
        Reserved_0945 = 945,
        Reserved_0946 = 946,
        Reserved_0947 = 947,
        Reserved_0948 = 948,
        Reserved_0949 = 949,
        Reserved_0950 = 950,
        Reserved_0951 = 951,
        Reserved_0952 = 952,
        Reserved_0953 = 953,
        Reserved_0954 = 954,
        Reserved_0955 = 955,
        Reserved_1001 = 1001,
        Reserved_1002 = 1002,
        Reserved_1003 = 1003,
        Reserved_1004 = 1004,
        Reserved_1005 = 1005,
        Reserved_1006 = 1006,
        Reserved_1007 = 1007,
        Reserved_1008 = 1008,
        Reserved_1009 = 1009,
        Reserved_1010 = 1010,
        Reserved_1101 = 1101,
        Reserved_1102 = 1102,
        Reserved_1103 = 1103,
        Reserved_1104 = 1104,
        Reserved_1105 = 1105,
        Reserved_1106 = 1106,
        Reserved_1107 = 1107,
        Reserved_1108 = 1108,
        Reserved_1109 = 1109,
        Reserved_1110 = 1110,
        Reserved_1201 = 1201,
        Reserved_1202 = 1202,
        Reserved_1203 = 1203,
        Reserved_1204 = 1204,
        Reserved_1205 = 1205,
        Reserved_1206 = 1206,
        Reserved_1207 = 1207,
        Reserved_1208 = 1208,
        Reserved_1209 = 1209,
        Reserved_1210 = 1210,
        DischargeW2ModuleAlarm = 1301,
        Reserved_1302 = 1302,
        DischargeW2ModuleAlarm2 = 1401,
        Reserved_1402 = 1402,
        Reserved_1403 = 1403,
        W2NotEmpty = 1404,
        W2NotEmptyAfterCheck = 1405,
        KnockerW2ModuleAlarm = 1501,
        Reserved_1502 = 1502,
        Reserved_1503 = 1503,
        Reserved_1504 = 1504,
        TopDockingModuleAlarm = 1601,
        Reserved_1602 = 1602,
        Reserved_1603 = 1603,
        Reserved_1604 = 1604,
        PositioningModuleAlarm_B = 1701,
        UnexpectedStopPositioningModule = 1702,
        WeigherPositionWasLost_B = 1703
    }
}