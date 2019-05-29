using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_OBJ
    {
        public static object layLoaiTaiKhoan(string tenDN, string mk)
        {
            return Sach_DAO.loaiTaiKhoan(tenDN, mk);
        }
        public static string layTenSach(string maSach)
        {
            return Sach_DAO.layTenSach(maSach);
        }
        public static string layTenDocGia(string maDocGia)
        {
            return Sach_DAO.layTenDocGia(maDocGia);
        }
        public static string layTenTacGia(string maTacGia)
        {
            return Sach_DAO.layTenTacGia(maTacGia);
        }
        public static string layTenTheLoai(string maTheLoai)
        {
            return Sach_DAO.layTenTheLoai(maTheLoai);
        }
        public static string layTenNXB(string maNXB)
        {
            return Sach_DAO.layTenNXB(maNXB);
        }
        public static string layMaTheTheoMaDocGia(string maDocGia)
        {
            return Sach_DAO.layMaTheTheoMaDocGia(maDocGia);
        }
        
        public static int demSoPhieuMuonChoDuyet()
        {
            return Sach_DAO.demSoPhieuMuonChoDuyet();
        }
        public static int demSoPhieuMuonTreHan()
        {
            return Sach_DAO.demSoPhieuMuonTreHan();
        }
        public static void taoMoiTKNV(string tenDN, string mk)
        {
            Sach_DAO.taoMoiTK(tenDN,mk);
        }
        public static void doiMK(string taiKhoan, string mkMoi)
        {
            Sach_DAO.doiMK(taiKhoan, mkMoi);
        }
        public static DataTable loadDSSach()
        {
            return Sach_DAO.loadDSSach();
        }
        public static DataTable loadDSTacGia()
        {
            return Sach_DAO.loadDSTacGia();
        }
        public static DataTable loadDSTheLoai()
        {
            return Sach_DAO.loadDSTheLoai();
        }
        public static DataTable loadDSNXB()
        {
            return Sach_DAO.loadDSNXB();
        }
        public static DataTable loadDSDocGia()
        {
            return Sach_DAO.loadDSDocGia();
        }
        public static DataTable loadDSLoaiDG()
        {
            return Sach_DAO.loadDSLoaiDG();
        }
        public static DataTable loadDSLoaiThe()
        {
            return Sach_DAO.loadDSLoaiThe();
        }
        public static DataTable loadDSThe()
        {
            return Sach_DAO.loadDSThe();
        }
        public static void themSach(Sach_DTO sach)
        {
            Sach_DAO.themSach(sach);
        }
        public static void suaSach(Sach_DTO sach)
        {
            Sach_DAO.suaSach(sach);
        }
        public static void xoaSach(string maSach)
        {
            Sach_DAO.xoaSach(maSach);
        }
        public static void themTG(TacGia_DTO tacGia)
        {
            Sach_DAO.themTG(tacGia);
        }
        public static void suaTG(TacGia_DTO tacGia)
        {
            Sach_DAO.suaTG(tacGia);
        }
        public static void xoaTG(string maTacGia)
        {
            Sach_DAO.xoaTG(maTacGia);
        }
        public static void themNXB(NXB_DTO nXB)
        {
            Sach_DAO.themNXB(nXB);
        }
        public static void suaNXB(NXB_DTO nXB)
        {
            Sach_DAO.suaNXB(nXB);
        }
        public static void xoaNXB(string maNXB)
        {
            Sach_DAO.xoaNXB(maNXB);
        }
        public static void themTL(TheLoai_DTO theLoai)
        {
            Sach_DAO.themTL(theLoai);
        }
        public static void suaTL(TheLoai_DTO theLoai)
        {
            Sach_DAO.suaTL(theLoai);
        }
        public static void xoaTL(string maTheLoai)
        {
            Sach_DAO.xoaTL(maTheLoai);
        }
       
        public static void themThe(The_DTO the)
        {
            Sach_DAO.themThe(the);
        }
        public static void themUser(string tenDN, string mK, int type)
        {
            Sach_DAO.themUser(tenDN, mK, type);
        }
        public static void suaUser(string tenDN, string mK, int type)
        {
            Sach_DAO.suaUser(tenDN, mK, type);
        }
        public static void xoaUser(string maDG)
        {
            Sach_DAO.xoaUser(maDG);
        }
        public static void themDG(DocGia_DTO docGia)
        {
            Sach_DAO.themDG(docGia);
        }
        public static void suaDG(DocGia_DTO docGia)
        {
            Sach_DAO.suaDG(docGia);
        }
        public static void xoaDG(string maDocGia)
        {
            Sach_DAO.xoaDG(maDocGia);
        }
        public static void xoaThe(string maThe)
        {
            Sach_DAO.xoaThe(maThe);
        }
        public static void suaThe(The_DTO the)
        {
            Sach_DAO.suaThe(the);
        }
        
       
        public static string layMaDocGiaTheoTenDocGia(string tenDocGia)
        {
            return Sach_DAO.layMaDocGiaTheoTenDocGia(tenDocGia);
        }
        public static string layMaSachTheoTenSach(string tenSach)
        {
            return Sach_DAO.layMaSachTheoTenSach(tenSach);
        }
       
        public static DocGia_DTO layTTDocGia(string maDocGia)
        {
            return DocGia_DAO.layTTDocGia(maDocGia);
        }

        public static string layTenLoaiDocGia(string maDocGia)
        {
            return DocGia_DAO.layTenLoaiDocGia(maDocGia);
        }

        public static The_DTO layTTThe(string maThe)
        {
            return The_DAO.layTTThe(maThe);
        }

    }
}
