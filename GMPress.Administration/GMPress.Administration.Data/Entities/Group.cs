using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GMPress.Data.Entities;

namespace GMPress.Administration.Data.Entities
{
    /// <summary>
    /// Группа прав доступа
    /// </summary>
    public abstract class Group : DisplayConverter
    {
        public Guid GroupID { get; set; }

        public string GroupName { get; set; }
        public IEnumerable<Rule> Rules { get; set; }

        public override string ToString() => GroupName;
    }

    public sealed class OnlineGroup : Group
    {
        public OnlineGroup()
        {
            GroupID = Guid.Parse("C820BA49-DFDF-4EF3-B855-979E1E0209D9");
            GroupName = "Online пользователь";
            Rules = new[]
            {
                new Rule
                {

                }
            }.ToList();
        }
       
    }
    public sealed class ManagerGroup : Group
    {
        public ManagerGroup()
        {
            GroupID = Guid.Parse("CF920DAC-6761-41EA-8848-F879C694774C");
            GroupName = "Менеджер";
            Rules = new[]
            {
                new Rule
                {

                }
            }.ToList();
        }
    }
    public sealed class PrepressGroup : Group
    {
        public PrepressGroup()
        {
            GroupID = Guid.Parse("C60B9980-4A0F-4ACF-951B-154973770410");
            GroupName = "Препресс";
            Rules = new[]
            {
                new Rule
                {

                }
            }.ToList();
        }
    }
}
