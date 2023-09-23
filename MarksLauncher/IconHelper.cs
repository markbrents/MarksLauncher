using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Runtime.InteropServices;

public class IconHelper
{
    private const int SHGFI_ICON = 0x100;
    private const int SHGFI_LARGEICON = 0x0;
    private const int SHGFI_SMALLICON = 0x1;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHFILEINFOW
    {
        public IntPtr hIcon;
        public int iIcon;
        public int dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    [DllImport("shell32.dll", EntryPoint = "SHGetFileInfoW")]
    private extern static int SHGetFileInfoW([In()][MarshalAs(UnmanagedType.LPTStr)] string pszPath, int dwFileAttributes, ref SHFILEINFOW psfi, int cbFileInfo, int uFlags);


    [DllImport("user32.dll", EntryPoint = "DestroyIcon")]
    private extern static bool DestroyIcon(System.IntPtr hIcon);

    public static Bitmap GetIcon(string PathName, bool LargeIco)
    {
        SHFILEINFOW fi = new SHFILEINFOW();
        fi = new SHFILEINFOW();
        if (LargeIco)
            SHGetFileInfoW(PathName, 0, ref fi, Marshal.SizeOf(fi), SHGFI_ICON | SHGFI_LARGEICON);
        else
            SHGetFileInfoW(PathName, 0, ref fi, Marshal.SizeOf(fi), SHGFI_ICON | SHGFI_SMALLICON);
        if (fi.hIcon == IntPtr.Zero)
            return null/* TODO Change to default(_) if this is not a reference type */;
        Bitmap bm = Icon.FromHandle(fi.hIcon).ToBitmap();
        DestroyIcon(fi.hIcon);
        return bm;
    }
}
