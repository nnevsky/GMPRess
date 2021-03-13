using System;
using GMPress.Data.ENUM;

namespace GMPress.Administration.Data.Entities
{
    /// <summary>
    /// Правило доступа
    /// </summary>
    public class Rule
    {
        public Guid RuleID { get; set; } = Guid.NewGuid();
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
        public ACCESS_LEVEL AccessLevel { get; set; }

        public override string ToString() => RuleName;
    }
}
