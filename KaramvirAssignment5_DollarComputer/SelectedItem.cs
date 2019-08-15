using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaramvirAssignment5_DollarComputer
{
    /// <summary>
    /// Application Name : KaramvirAssignment5_DollarComputer
    /// 
    /// Author Of the Project : Karamvir Singh
    /// 
    /// Student ID : 301044965
    /// 
    /// Application Development Date : 15 Aug 2019
    class SelectedItem
    {
        int _itemProductID; double _itemCost;
        string _itemCondition, _itemPlatform, _itemOS, _itemManufac, _itemModel, _itemMemory, _itemLcd, _itemHdd, _itemCpuBrand, _itemCpuNumber,
               __itemGpuType, _itemCpuType, _itemCpuSpeed, _itemWebcam;

        public SelectedItem()
        {

        }
        public int ProductID
        {
            get
            {
                return _itemProductID;
            }

            set
            {
                _itemProductID = value;
            }
        }

        public double Cost
        {
            get
            {
                return _itemCost;
            }

            set
            {
                _itemCost = value;
            }
        }

        public string Condition
        {
            get
            {
                return _itemCondition;
            }

            set
            {
                _itemCondition = value;
            }
        }

        public string Platform
        {
            get
            {
                return _itemPlatform;
            }

            set
            {
                _itemPlatform = value;
            }
        }

        public string OS
        {
            get
            {
                return _itemOS;
            }

            set
            {
                _itemOS = value;
            }
        }

        public string Manufac
        {
            get
            {
                return _itemManufac;
            }

            set
            {
                _itemManufac = value;
            }
        }

        public string Model
        {
            get
            {
                return _itemModel;
            }

            set
            {
                _itemModel = value;
            }
        }

        public string Memory
        {
            get
            {
                return _itemMemory;
            }

            set
            {
                _itemMemory = value;
            }
        }

        public string Lcd
        {
            get
            {
                return _itemLcd;
            }

            set
            {
                _itemLcd = value;
            }
        }

        public string Hdd
        {
            get
            {
                return _itemHdd;
            }

            set
            {
                _itemHdd = value;
            }
        }

        public string CpuBrand
        {
            get
            {
                return _itemCpuBrand;
            }

            set
            {
                _itemCpuBrand = value;
            }
        }

        public string CpuNumber
        {
            get
            {
                return _itemCpuNumber;
            }

            set
            {
                _itemCpuNumber = value;
            }
        }

        public string GpuType
        {
            get
            {
                return __itemGpuType;
            }

            set
            {
                __itemGpuType = value;
            }
        }

        public string CpuType
        {
            get
            {
                return _itemCpuType;
            }

            set
            {
                _itemCpuType = value;
            }
        }

        public string CpuSpeed
        {
            get
            {
                return _itemCpuSpeed;
            }

            set
            {
                _itemCpuSpeed = value;
            }
        }

        public string Webcam
        {
            get
            {
                return _itemWebcam;
            }

            set
            {
                _itemWebcam = value;
            }
        }
    }
}

