namespace CodeGenerator.Generator
{
    public abstract class GeneratorBase
    {
        public abstract void CreateModel(string tableName, string directory, string name);

        public abstract void CreateDAL(string tableName, string directory, string name);

        public abstract void CreateBLL(string tableName, string directory, string name);
    }
}
