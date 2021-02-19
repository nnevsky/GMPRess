using System;
using GMPress.Data.Entities;

namespace GMPress.Administration.Data.Entities
{
    /// <summary>
    /// Правило доступа
    /// </summary>
    public class Rule : DisplayConverter
    {
        public Guid RuleID { get; set; }
        /// <summary>
        /// Наименование правила доступа
        /// </summary>
        public string RuleName { get; set; }
        /// <summary>
        /// Альтернативное короткое наименование правила доступа
        /// </summary>
        public string AlterName { get; set; }
        /// <summary>
        /// Флаг включения правила доступа
        /// </summary>
        public bool RuleChecked { get; set; }

        public override string ToString() => RuleName;
    }
}
