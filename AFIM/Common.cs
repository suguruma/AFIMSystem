using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // 描画処理
using System.IO;                // 入出力
using System.Collections;       // 並び替え(クラスの追加)

namespace AFIM
{
    class Common
    {

    }
    
    //=== IComparerインターフェイスを実装(並び替える方法を定義したクラス) ===//
    public class CustomComparer : IComparer
    {
        private int sortOrder;
        private Comparer comparer;

        public CustomComparer(SortOrder order)
        {
            this.sortOrder = (order == SortOrder.Descending ? -1 : 1);
            this.comparer = new Comparer(
                System.Globalization.CultureInfo.CurrentCulture);
        }

        //並び替え方を定義する
        public int Compare(object x, object y)
        {
            int result = 0;

            DataGridViewRow rowx = (DataGridViewRow)x;
            DataGridViewRow rowy = (DataGridViewRow)y;

            //はじめの列のセルの値を比較し、同じならば次の列を比較する
            for (int i = 0; i < rowx.Cells.Count; i++)
            {
                result = this.comparer.Compare(
                    rowx.Cells[i].Value, rowy.Cells[i].Value);
                if (result != 0)
                    break;
            }

            //結果を返す
            return result * this.sortOrder;
        }
    }

    //=== 文字列が数値かどうか判断する ===//
    public sealed class Validation
    {
        //指定した文字列が数値であればtrue.それ以外はfalse.
        public static bool IsNumeric(string stTarget)
        {
            double dNullable;
            return double.TryParse(
                stTarget,
                System.Globalization.NumberStyles.Any,
                null,
                out dNullable
            );
        }

        // 指定したオブジェクトが数値であればtrue.それ以外はfalse.
        public static bool IsNumeric(object oTarget)
        {
            return IsNumeric(oTarget.ToString());
        }
    }
}
