﻿//**********************************************************************************
//* Ｄ層 自動生成・テストクラス
//**********************************************************************************

// テスト用クラスなので、必要に応じて流用 or 削除して下さい。

//**********************************************************************************
//* クラス名        ：DaoShippers
//* クラス日本語名  ：自動生成Ｄａｏクラス
//*
//* 作成日時        ：2014/2/9
//* 作成者          ：棟梁 D層自動生成ツール（墨壺）, 日立 太郎
//* 更新履歴        ：
//*
//*  日時        更新者            内容
//*  ----------  ----------------  -------------------------------------------------
//*  20xx/xx/xx  ＸＸ ＸＸ         ＸＸＸＸ
//*  2012/06/14  西野  大介        ResourceLoaderに加え、EmbeddedResourceLoaderに対応
//*  2013/09/09  西野  大介        ExecGenerateSQLメソッドを追加した（バッチ更新用）。
//*  2014/11/20  Sandeep           Implemented CommandTimeout property and SetCommandTimeout method.
//*  2015/06/04  Sai               Replaced SqlCommand property with IDbCommand property in SetCommandTimeout method.
//*  2019/05/14  西野  大介        クエリ再利用の性能向上対策コードの追加
//**********************************************************************************

#region using

// System～
using System;
using System.IO;
using System.Data;
using System.Collections;
using System.Collections.Concurrent;

// フレームワーク
using Touryo.Infrastructure.Framework.Dao;
using Touryo.Infrastructure.Framework.Common;

// 部品
using Touryo.Infrastructure.Public.Db;
using Touryo.Infrastructure.Public.Util;

// 業務フレームワーク
using Touryo.Infrastructure.Business.Dao;

#endregion

namespace WebForms_Sample
{
    /// <summary>自動生成Ｄａｏクラス</summary>
    public class DaoShippers : MyBaseDao
    {
        /// <summary>クエリのキャッシュ</summary>
        protected static ConcurrentDictionary<string, string> CDicQueryCache = new ConcurrentDictionary<string, string>();

        #region インスタンス変数

        /// <summary>キャッシュID</summary>
        string CacheId = "";
    
        #region パラメタ
        /// <summary>ユーザ パラメタ（文字列置換）用ハッシュ テーブル</summary>
        protected Hashtable HtUserParameter = new Hashtable();
        /// <summary>パラメタ ライズド クエリのパラメタ用ハッシュ テーブル</summary>
        protected Hashtable HtParameter = new Hashtable();
        #endregion

        #region CommandTimeout

        /// <summary>CommandTimeout</summary>
        private int _commandTimeout = -1;

        #region プロパティ プロシージャ

        /// <summary>CommandTimeout</summary>
        /// <remarks>自由に（拡張して）利用できる。</remarks>
        public int CommandTimeout
        {
            set
            {
                this._commandTimeout = value;
            }
        }

        #endregion

        #endregion
        
        #endregion

        #region コンストラクタ

        /// <summary>コンストラクタ</summary>
        /// <param name="dam">BaseDam</param>
        public DaoShippers(BaseDam dam) : base(dam) { }

        /// <summary>コンストラクタ</summary>
        /// <param name="dam">BaseDam</param>
        /// <param name="cacheId">キャッシュ用ID</param>
        public DaoShippers(BaseDam dam, string cacheId) : base(dam)
        {
            this.CacheId = cacheId;
        }

        #endregion

        #region 共通関数（パラメタの制御）

        /// <summary>To Set CommandTimeout</summary>
        private void SetCommandTimeout()
        {
            // If CommandTimeout is >= 0 then set CommandTimeout.
            // Else skip, automatically it will set default CommandTimeout.
            if (this._commandTimeout >= 0)
            {
                this.GetDam().DamIDbCommand.CommandTimeout = this._commandTimeout;
            }
        }

        /// <summary>ユーザ パラメタ（文字列置換）をハッシュ テーブルに設定する。</summary>
        /// <param name="userParamName">ユーザ パラメタ名</param>
        /// <param name="userParamValue">ユーザ パラメタ値</param>
        public void SetUserParameteToHt(string userParamName, string userParamValue)
        {
            // ユーザ パラメタをハッシュ テーブルに設定
            this.HtUserParameter[userParamName] = userParamValue;
        }

        /// <summary>パラメタ ライズド クエリのパラメタをハッシュ テーブルに設定する。</summary>
        /// <param name="paramName">パラメタ名</param>
        /// <param name="paramValue">パラメタ値</param>
        public void SetParameteToHt(string paramName, object paramValue)
        {
            // ユーザ パラメタをハッシュ テーブルに設定
            this.HtParameter[paramName] = paramValue;
        }

        /// <summary>
        /// ・ユーザ パラメタ（文字列置換）
        /// ・パラメタ ライズド クエリのパラメタ
        /// を格納するハッシュ テーブルをクリアする。
        /// </summary>
        public void ClearParametersFromHt()
        {
            // ユーザ パラメタ（文字列置換）用ハッシュ テーブルを初期化
            this.HtUserParameter = new Hashtable();
            // パラメタ ライズド クエリのパラメタ用ハッシュ テーブルを初期化
            this.HtParameter = new Hashtable();
        }

        /// <summary>パラメタの設定（内部用）</summary>
        protected void SetParametersFromHt()
        {
            // ユーザ パラメタ（文字列置換）を設定する。
            foreach (string userParamName in this.HtUserParameter.Keys)
            {
                this.SetUserParameter(userParamName, this.HtUserParameter[userParamName].ToString());
            }

            // パラメタ ライズド クエリのパラメタを設定する。
            foreach (string paramName in this.HtParameter.Keys)
            {
                this.SetParameter(paramName, this.HtParameter[paramName]);
            }
        }

        #endregion

        #region プロパティ プロシージャ（setter、getter）


        /// <summary>ShipperID列（主キー列）に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>更新処理時のSET句で使用するパラメタを除く</remarks>
        public object PK_ShipperID
        {
            set
            {
                this.HtParameter["ShipperID"] = value;
            }
            get
            {
                return this.HtParameter["ShipperID"];
            }
        }



        /// <summary>CompanyName列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>更新処理時のSET句で使用するパラメタを除く</remarks>
        public object CompanyName
        {
            set
            {
                this.HtParameter["CompanyName"] = value;
            }
            get
            {
                return this.HtParameter["CompanyName"];
            }
        }

        /// <summary>Phone列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>更新処理時のSET句で使用するパラメタを除く</remarks>
        public object Phone
        {
            set
            {
                this.HtParameter["Phone"] = value;
            }
            get
            {
                return this.HtParameter["Phone"];
            }
        }


        /// <summary>Set_ShipperID_forUPD列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>更新処理時のSET句で使用するパラメタ専用</remarks>
        public object Set_ShipperID_forUPD
        {
            set
            {
                this.HtParameter["Set_ShipperID_forUPD"] = value;
            }
            get
            {
                return this.HtParameter["Set_ShipperID_forUPD"];
            }
        }


        /// <summary>Set_CompanyName_forUPD列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>更新処理時のSET句で使用するパラメタ専用</remarks>
        public object Set_CompanyName_forUPD
        {
            set
            {
                this.HtParameter["Set_CompanyName_forUPD"] = value;
            }
            get
            {
                return this.HtParameter["Set_CompanyName_forUPD"];
            }
        }


        /// <summary>Set_Phone_forUPD列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>更新処理時のSET句で使用するパラメタ専用</remarks>
        public object Set_Phone_forUPD
        {
            set
            {
                this.HtParameter["Set_Phone_forUPD"] = value;
            }
            get
            {
                return this.HtParameter["Set_Phone_forUPD"];
            }
        }



        /// <summary>ShipperID_Like列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>動的参照処理時のLIKE検索で使用するパラメタ専用</remarks>
        public object ShipperID_Like
        {
            set
            {
                this.HtParameter["ShipperID_Like"] = value;
            }
            get
            {
                return this.HtParameter["ShipperID_Like"];
            }
        }


        /// <summary>CompanyName_Like列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>動的参照処理時のLIKE検索で使用するパラメタ専用</remarks>
        public object CompanyName_Like
        {
            set
            {
                this.HtParameter["CompanyName_Like"] = value;
            }
            get
            {
                return this.HtParameter["CompanyName_Like"];
            }
        }


        /// <summary>Phone_Like列に対するパラメタ ライズド クエリのパラメタを設定する。</summary>
        /// <remarks>動的参照処理時のLIKE検索で使用するパラメタ専用</remarks>
        public object Phone_Like
        {
            set
            {
                this.HtParameter["Phone_Like"] = value;
            }
            get
            {
                return this.HtParameter["Phone_Like"];
            }
        }


        #endregion

        #region クエリ メソッド

        #region クエリのキャッシュ処理

        /// <summary>ファイル or キャッシュからSetSqlByFile2する。</summary>
        /// <param name="sqlFileName">string</param>
        protected void SetSqlFromFileOrCache(string sqlFileName)
        {
            if (string.IsNullOrEmpty(this.CacheId))
            {
                // キャッシュ設定なし
                // ファイルからSQL（Insert）を設定する。
                this.SetSqlByFile2(sqlFileName);
            }
            else
            {
                // キャッシュ設定あり
                string temp = this.CacheId + sqlFileName;
                if (DaoShippers.CDicQueryCache.ContainsKey(temp))
                {
                    // キャッシュからSQL（Insert）を設定する。
                    this.SetSqlByCommand(DaoShippers.CDicQueryCache[temp]);
                }
                else
                {
                    // ファイルからSQL（Insert）を設定する。
                    this.SetSqlByFile2(sqlFileName);
                }
            }
        }

        /// <summary>クエリをキャッシュする。</summary>
        /// <param name="sqlFileName">string</param>
        protected void SetSqlToCache(string sqlFileName)
        {
            string temp = this.CacheId + sqlFileName;

            if (!string.IsNullOrEmpty(this.CacheId)
                && !DaoShippers.CDicQueryCache.ContainsKey(temp))
            {
                // クエリをキャッシュ
                DaoShippers.CDicQueryCache[temp] = this.GetDam().DamIDbCommand.CommandText;
            }
        }

        #endregion

        #region Insert

        /// <summary>１レコード挿入する。</summary>
        /// <returns>挿入された行の数</returns>
        public int S1_Insert()
        {
            string sqlFileName = "DaoShippers_S1_Insert.sql";

            // SQL（Insert）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
            
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（Insert）を実行し、戻り値を戻す。
            int i = this.ExecInsUpDel_NonQuery();
            this.SetSqlToCache(sqlFileName);
            return i;
        }

        /// <summary>１レコード挿入する。</summary>
        /// <returns>挿入された行の数</returns>
        /// <remarks>パラメタで指定した列のみ挿入値が有効になる。</remarks>
        public int D1_Insert()
        {
            string sqlFileName = "DaoShippers_D1_Insert.xml";

            // ファイルからSQL（DynIns）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();

            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（DynIns）を実行し、戻り値を戻す。
            int i = this.ExecInsUpDel_NonQuery();
            this.SetSqlToCache(sqlFileName);
            return i;
        }

        #endregion

        #region Select

        /// <summary>主キーを指定し、１レコード参照する。</summary>
        /// <param name="dt">結果を格納するDataTable</param>
        public void S2_Select(DataTable dt)
        {
            string sqlFileName = "DaoShippers_S2_Select.xml";

            // ファイルからSQL（Select）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();

            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（Select）を実行し、戻り値を戻す。
            this.ExecSelectFill_DT(dt);
            this.SetSqlToCache(sqlFileName);
        }

        /// <summary>検索条件を指定し、結果セットを参照する。</summary>
        /// <param name="dt">結果を格納するDataTable</param>
        public void D2_Select(DataTable dt)
        {
            string sqlFileName = "DaoShippers_D2_Select.xml";

            // ファイルからSQL（DynSel）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
        
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（DynSel）を実行し、戻り値を戻す。
            this.ExecSelectFill_DT(dt);
            this.SetSqlToCache(sqlFileName);
        }

        #endregion

        #region Update

        /// <summary>主キーを指定し、１レコード更新する。</summary>
        /// <returns>更新された行の数</returns>
        /// <remarks>パラメタで指定した列のみ更新値が有効になる。</remarks>
        public int S3_Update()
        {
            string sqlFileName = "DaoShippers_S3_Update.xml";

            // ファイルからSQL（Update）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
        
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（Update）を実行し、戻り値を戻す。
            int i = this.ExecInsUpDel_NonQuery();
            this.SetSqlToCache(sqlFileName);
            return i;
        }

        /// <summary>任意の検索条件でデータを更新する。</summary>
        /// <returns>更新された行の数</returns>
        /// <remarks>パラメタで指定した列のみ更新値が有効になる。</remarks>
        public int D3_Update()
        {
            string sqlFileName = "DaoShippers_D3_Update.xml";

            // ファイルからSQL（DynUpd）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
            
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（DynUpd）を実行し、戻り値を戻す。
            int i = this.ExecInsUpDel_NonQuery();
            this.SetSqlToCache(sqlFileName);
            return i;
        }

        #endregion

        #region Delete

        /// <summary>主キーを指定し、１レコード削除する。</summary>
        /// <returns>削除された行の数</returns>
        public int S4_Delete()
        {
            string sqlFileName = "DaoShippers_S4_Delete.xml";

            // ファイルからSQL（Delete）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
            
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（Delete）を実行し、戻り値を戻す。
            int i = this.ExecInsUpDel_NonQuery();
            this.SetSqlToCache(sqlFileName);
            return i;
        }

        /// <summary>任意の検索条件でデータを削除する。</summary>
        /// <returns>削除された行の数</returns>
        public int D4_Delete()
        {
            string sqlFileName = "DaoShippers_D4_Delete.xml";

            // ファイルからSQL（DynDel）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
            
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（DynDel）を実行し、戻り値を戻す。
            int i = this.ExecInsUpDel_NonQuery();
            this.SetSqlToCache(sqlFileName);
            return i;
        }

        #endregion

        #region 拡張メソッド

        /// <summary>テーブルのレコード件数を取得する</summary>
        /// <returns>テーブルのレコード件数</returns>
        public object D5_SelCnt()
        {
            string sqlFileName = "DaoShippers_D5_SelCnt.xml";

            // ファイルからSQL（DynSelCnt）を設定する。
            this.SetSqlFromFileOrCache(sqlFileName);

            // Set CommandTimeout
            this.SetCommandTimeout();
            
            // パラメタの設定
            this.SetParametersFromHt();

            // SQL（SELECT COUNT）を実行し、戻り値を戻す。
            object o = this.ExecSelectScalar();
            this.SetSqlToCache(sqlFileName);
            return o;
        }

        /// <summary>静的SQLを生成する。</summary>
        /// <param name="fileName">ファイル名</param>
        /// <param name="sqlUtil">SQLユーティリティ</param>
        /// <returns>生成した静的SQL</returns>
        public string ExecGenerateSQL(string fileName, SQLUtility sqlUtil)
        {
            // ファイルからSQLを設定する。
            this.SetSqlByFile2(fileName);

            // Set CommandTimeout
            this.SetCommandTimeout();

            // パラメタの設定
            this.SetParametersFromHt();

            return base.ExecGenerateSQL(sqlUtil);
        }

        #endregion

        #endregion
    }
}
