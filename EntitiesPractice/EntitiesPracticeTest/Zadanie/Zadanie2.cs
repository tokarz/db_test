using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesPracticeTest.Zadanie
{
    public interface DbReader
    {
        string ReadById(int id);
    }

    public interface DbWriter
    {
        string WriteById(int id);
    }
    public interface DbMapper
    {
        string Map(string element);
    }


    public class Zadanie2
    {
        private DbReader _Reader;
        private DbWriter _Writer;
        private DbMapper _Mapper;

        public Zadanie2(DbReader reader, DbWriter writer, DbMapper mapper)
        {
            this._Reader = reader;
            this._Writer = writer;
            this._Mapper = mapper;
        }

        public string FetchFromDbById(int id)
        {
            throw new NotImplementedException("Ale jak?");
        }

    }
}
