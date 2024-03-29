﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG100
{
    public class CmdData
    {
        //Music
        public byte[] MP3_34 = { 0x4a, 0x01, 0x07, 0x40, 0x34, 0x44, 0x7c };
        public byte[] MP3_27 = { 0x4a, 0x01, 0x07, 0x40, 0x27, 0x44, 0x6f };

        //Control
        //Stop
        public byte[] EmgStop = { 0x4A, 0x01, 0x07, 0x23, 0x02, 0x44, 0x29 };
        public byte[] CarStop1 = { 0x4A, 0x01, 0x07, 0x23, 0x0E, 0x44, 0x25 };
        public byte[] CarStop2 = { 0x4A, 0x01, 0x07, 0x23, 0x0F, 0x44, 0x24 };

        //Act
        //往後走
        public byte[] Back = { 0x4A, 0x01, 0x09, 0x23, 0x06, 0x23, 0x01, 0x44, 0X01 };
        //往前走
        public byte[] Front = { 0x4A, 0x01, 0x09, 0x23, 0x05, 0x23, 0x01, 0x44, 0X02 };
        //向左轉90度
        byte[] R90 = { 0x4A, 0x01, 0x07, 0x23, 0x11, 0x44, 0x3A };
        //向右轉90度
        byte[] L90 = { 0x4A, 0x01, 0x07, 0x23, 0x12, 0x44, 0x39 };
        //向右180度
        byte[] R180 = { 0x4A, 0x01, 0x09, 0x23, 0x11, 0x23, 0x11, 0x44, 0x06 };
        //向左180度
        byte[] L180 = { 0x4A, 0x01, 0x09, 0x23, 0x12, 0x23, 0x12, 0x44, 0x06 };

        //Setting : 預設 -> 低速前進跟隨左軌移動
        //沿右軌行走 一律正行
        byte[] RW = { 0x4A, 0x01, 0x07, 0x23, 0x16, 0x44, 0x3D };
        //沿左軌行走 一律正行
        byte[] LW = { 0x4A, 0x01, 0x07, 0x23, 0x17, 0x44, 0x3C };
        //沿中軌行走 一律正行
        byte[] MW = { 0x4A, 0x01, 0x07, 0x23, 0x18, 0x44, 0x33 };
        //高速
        byte[] HS = { 0x4A, 0x01, 0x07, 0x23, 0x0B, 0x44, 0x20 };
        //中速
        byte[] MS = { 0x4A, 0x01, 0x07, 0x23, 0x0C, 0x44, 0x27 };
        //低速
        byte[] LS = { 0x4A, 0x01, 0x07, 0x23, 0x0D, 0x44, 0x26 };
        //開啟IR
        byte[] IRON = { 0x4A, 0x01, 0x11, 0x23, 0x67, 0x23, 0x51, 0x23, 0x5A, 0x23, 0x6D, 0x23, 0x73, 0x23, 0x84, 0x44, 0xE8 };
        //關閉IR

        //Mannul
        //單動往前
        public byte[] MFront = { 0x4A, 0x01, 0x09, 0x23, 0x35, 0x23, 0x01, 0X44, 0x32 };
        //單動往後
        public byte[] MBack = { 0x4A, 0x01, 0x09, 0x23, 0x36, 0x23, 0x01, 0X44, 0x31 };
        //單動往左
        public byte[] MLeft = { 0x4A, 0x01, 0x09, 0x23, 0x34, 0x23, 0x01, 0X44, 0x33 };
        //單動往右
        public byte[] MRight = { 0x4A, 0x01, 0x09, 0x23, 0x33, 0x23, 0x01, 0X44, 0x34 };

        public byte[] Test = { 0x4A, 0x01, 0x0D, 0x23, 0x05, 0x23, 0x0B, 0x23, 0x16, 0x23, 0x01, 0X44, 0x1B };
    }
}