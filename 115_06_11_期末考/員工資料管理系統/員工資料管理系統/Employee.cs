using System;

namespace 員工資料管理系統
{
    /// <summary>
    /// Employee 類別
    /// 功能：
    /// - 表示單一員工的資料（編號、姓名、部門、職稱）
    /// - 提供多載建構子以便不同來源建立物件
    /// - 提供將物件轉為檔案儲存格式的方法，以及由檔案行反向解析的方法
    /// 注意：
    /// - IdNumber 使用 int（在 UI 與檔案處理時需做 int 解析驗證）
    /// - 檔案格式與解析格式需一致：IdNumber|Name|Department|Position
    /// </summary>
    public class Employee
    {
        // 員工姓名
        public string Name { get; set; }

        // 員工編號（整數）
        public int IdNumber { get; set; }

        // 員工所屬部門
        public string Department { get; set; }

        // 員工職稱
        public string Position { get; set; }

        // 無參數建構子
        // - 預設：Name、Department、Position 為空字串；IdNumber 為 0
        // - 避免 null 值，方便 UI 與檔案序列化處理
        public Employee()
        {
            Name = string.Empty;
            IdNumber = 0;
            Department = string.Empty;
            Position = string.Empty;
        }

        // 兩參數建構子 - 可設定 Name 與 IdNumber
        // Department、Position 預設為空字串
        // 適合只知道編號與姓名時建立物件的情境
        public Employee(string name, int idNumber)
        {
            Name = name ?? string.Empty;
            IdNumber = idNumber;
            Department = string.Empty;
            Position = string.Empty;
        }

        // 四參數建構子 - 完整設定所有屬性
        // 適合從檔案或完整輸入建立物件
        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name ?? string.Empty;
            IdNumber = idNumber;
            Department = department ?? string.Empty;
            Position = position ?? string.Empty;
        }

        // 覆寫 ToString()，便於除錯或在 ListBox 等 UI 快速顯示
        // 此處使用 tab 分隔，顯示 IdNumber 與 Name（例如：1001\tAlice）
        public override string ToString()
        {
            return $"{IdNumber}\t{Name}";
        }

        // 將 Employee 物件格式化為檔案中儲存的一行字串
        // 格式：IdNumber|Name|Department|Position
        // 使用 '|' 為分隔符，儲存時需確保文字本身不包含該分隔符或先處理
        public string ToFileLine()
        {
            return $"{IdNumber}|{Name}|{Department}|{Position}";
        }

        // 嘗試從檔案行解析成 Employee 物件
        // - 若解析成功，回傳 true 並透過 out 傳出 Employee 物件
        // - 若格式錯誤或 Id 無法轉為整數，回傳 false 並將 emp 設為 null
        // 解析規則：
        //  1. 行不得為空或空白
        //  2. 以 '|' 分割後必須正好有 4 個欄位
        //  3. 第一欄必須可轉為 int（IdNumber）
        //  4. 其餘欄位直接當作字串（若為 null 由建構子轉為 empty）
        public static bool TryParseFromFileLine(string line, out Employee emp)
        {
            emp = null;

            // 基本驗證：空行視為失敗
            if (string.IsNullOrWhiteSpace(line)) return false;

            // 以 '|' 分隔，預期 4 欄
            var parts = line.Split('|');
            if (parts.Length != 4) return false;

            // 解析 Id（第 0 欄）為整數，失敗則回傳 false
            if (!int.TryParse(parts[0], out int id)) return false;

            // 建立 Employee 物件（使用四參數建構子）
            emp = new Employee(parts[1], id, parts[2], parts[3]);
            return true;
        }
    }
}