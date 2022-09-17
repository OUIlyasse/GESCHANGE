using GESCHANGE.Db;
using GESCHANGE.Proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace GESCHANGE.Proc
{
    internal class CRUD<TEntity> : iData<TEntity> where TEntity : class
    {
        #region Variables

        private GESSRMAEntities db = new GESSRMAEntities();

        #endregion Variables

        #region Codes

        public bool Add(TEntity entity)
        {
            try
            {
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                db.Set<TEntity>().Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(object valeur)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAllData()
        {
            try
            {
                return db.Set<TEntity>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<TEntity> GetDataBy(Expression<Func<TEntity, bool>> p)
        {
            try
            {
                return db.Set<TEntity>().Where(p);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<TEntity> GetMaxID(Expression<Func<TEntity, bool>> p)
        {
            try
            {
                return db.Set<TEntity>().Where(p);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                db.Set<TEntity>().AddOrUpdate(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion Codes
    }
}