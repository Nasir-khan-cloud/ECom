using BeratenECommerceDataAccess.DbModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml;

namespace BeratenECommerceDataAccess.Managers
{
    public class BaseDataManager
    {
        protected BeratenECommerceModel dbModel;

        public BaseDataManager(BeratenECommerceModel model)
        {
            dbModel = model;
        }
        protected IList<T> GetEntityListData<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            try
            {
                return dbModel.Set<T>().Where(predicate).ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
        protected T FindEntity<T>(int primaryKey) where T : class
        {
            try
            {
                return dbModel.Set<T>().Find(primaryKey);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }


        //#region APIs

        //protected T FindEntity<T>(int primaryKey) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().Find(primaryKey);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected async Task<T> FindEntityAsync<T>(int primaryKey) where T : class
        //{
        //    try
        //    {
        //        return await dbModel.Set<T>().FindAsync(primaryKey);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        ////protected T FindEntityNoTracking<T>(int primaryKey) where T : class
        ////{
        ////    try
        ////    {
        ////        return dbModel.Set<T>().AsNoTracking(). .Find(primaryKey);
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Debug.WriteLine(ex.ToString());
        ////        throw;
        ////    }
        ////}

        //protected T FindEntityNoTracking<T>(Expression<Func<T, bool>> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().AsNoTracking().FirstOrDefault(predicate);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected K GetEntityFirstRowColumn<T, K>(Expression<Func<T, bool>> predicate, Expression<Func<T, K>> select) where T : class where K : struct
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().AsNoTracking().Where(predicate).Select(select).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected int GetEntityRowCount<T>(Expression<Func<T, bool>> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().Where(predicate).Count();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected T GetEntityFirstRowData<T>(Expression<Func<T, bool>> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().Where(predicate).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected T GetEntityLastRowData<T>(Func<T, bool> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().AsEnumerable().LastOrDefault(predicate);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected T GetEntityLastRowDataNoTracking<T>(Func<T, bool> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().AsNoTracking().AsEnumerable().LastOrDefault(predicate);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected bool GetEntityAny<T>(Expression<Func<T, bool>> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().Where(predicate).Any();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected IList<T> GetEntityListData<T>(Expression<Func<T, bool>> predicate) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().Where(predicate).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected IList<T> GetEntityListData<T>() where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected IList<T> GetEntityListDataNoTracking<T>() where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().AsNoTracking().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected T GetRowData<T>(string interpolatedStoredProc) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().FromSqlRaw(interpolatedStoredProc).AsEnumerable().FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected IList<T> GetLookupCollection<T>() where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().AsNoTracking().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected IList<T> GetListData<T>(string interpolatedStoredProc) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().FromSqlRaw(interpolatedStoredProc).AsNoTracking().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());

        //        throw;
        //    }
        //}

        //protected IList<T> GetListData<T>(string interpolatedStoredProc, params object[] parameters) where T : class
        //{
        //    try
        //    {
        //        return dbModel.Set<T>().FromSqlRaw(interpolatedStoredProc, parameters).AsNoTracking().ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected bool ExecuteSqlInterpolated(System.FormattableString sql)
        //{
        //    try
        //    {
        //        int val = dbModel.Database.ExecuteSqlInterpolated(sql);
        //        return val > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected async Task<bool> ExecuteSqlAsync(string interpolatedStoredProc)
        //{
        //    try
        //    {
        //        await dbModel.Database.ExecuteSqlRawAsync(interpolatedStoredProc);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected bool MarkedForDelete(string interpolatedStoredProc)
        //{
        //    try
        //    {
        //        dbModel.Database.ExecuteSqlRaw(interpolatedStoredProc);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected bool RemoveEntity<T>(int id) where T : class
        //{
        //    try
        //    {
        //        var entity = dbModel.Set<T>().Find(id);

        //        string jsonString = JsonConvert.SerializeObject(entity, Formatting.None);
        //        JObject data = JObject.Parse(jsonString);

        //        if (entity != null)
        //        {

        //            HistoricalDeletedRecord hRec = new HistoricalDeletedRecord()
        //            {
        //                TableName = entity.GetType().Name,
        //                Data = jsonString,
        //                DeletedOn = DateTime.UtcNow,
        //                DeletedBy = data.GetValue("RecordedBy")?.ToString()
        //            };

        //            dbModel.Add(hRec);
        //            dbModel.Remove<T>(entity);
        //            dbModel.SaveChanges();
        //        }

        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected async Task<bool> AddUpdateEntityAsync<T>(T entity, bool keepDettached = true) where T : class
        //{
        //    try
        //    {
        //        if (dbModel.Entry<T>(entity).IsKeySet)
        //            dbModel.Update<T>(entity);
        //        else
        //            dbModel.Add<T>(entity);

        //        await dbModel.SaveChangesAsync();

        //        if (keepDettached)
        //        {
        //            dbModel.Entry<T>(entity).State = EntityState.Detached;
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected bool AddUpdateEntity<T>(T entity, bool keepDettached = true) where T : class
        //{
        //    try
        //    {
        //        if (dbModel.Entry<T>(entity).IsKeySet)
        //            dbModel.Update<T>(entity);
        //        else
        //            dbModel.Add<T>(entity);

        //        dbModel.SaveChanges();

        //        if (keepDettached)
        //        {
        //            dbModel.Entry<T>(entity).State = EntityState.Detached;
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}

        //protected bool AddEntityRange<T>(List<T> entityList) where T : class
        //{
        //    try
        //    {
        //        dbModel.AddRange(entityList);
        //        dbModel.SaveChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}


        //protected bool UpdateAndArchiveEntity<T>(T entity, T toBeArchived, bool keepDettached = true) where T : class
        //{
        //    try
        //    {
        //        string jsonString = JsonConvert.SerializeObject(toBeArchived, Formatting.None);
        //        dbModel.Entry<T>(toBeArchived).State = EntityState.Detached;

        //        if (toBeArchived == null)
        //        {
        //            return false;
        //        }

        //        //string jsonString = JsonConvert.SerializeObject(toBeArchived, Formatting.None);
        //        JObject data = JObject.Parse(jsonString);

        //        HistoricalUpdatedRecord hRec = new HistoricalUpdatedRecord()
        //        {
        //            TableName = toBeArchived.GetType().Name,
        //            Data = jsonString,
        //            UpdatedOn = DateTime.UtcNow,
        //            UpdatedBy = data.GetValue("RecordedBy").ToString(),
        //            RecordId = (int)data.GetValue("Id")
        //        };

        //        dbModel.Update<T>(entity);
        //        dbModel.Add(hRec);

        //        dbModel.SaveChanges();

        //        if (keepDettached)
        //        {
        //            dbModel.Entry<T>(entity).State = EntityState.Detached;
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //        throw;
        //    }
        //}
        //#endregion
    }
}