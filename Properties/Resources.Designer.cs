﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirehoseFinder.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FirehoseFinder.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Однокнопочная программа с GUI для подбора программеров (firehose) для телефонов на базе процессоров от Qualcomm..
        /// </summary>
        internal static string String_about {
            get {
                return ResourceManager.GetString("String_about", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 1. q. Как формируется рейтинг файла в папке с программерами? a. Если файл размером меньше 12кБ - рейтинг 0, он не обрабатывается (у него просто не хватает байт для программирования). Рейтинг 1 у файла, начинающегося на ELF. Это могут быть любые эльф-файлы (программеры, xbl и т.п.). Рейтинг увеличивается до 2, если в файле есть подпись программера (fh@0x%08). К рейтингу добавляется 1, если SWID (идентификатор программного обеспечения) начинается с 3 (разрешение на запись в память), ещё +1 балл к рейтингу есл [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string String_faq1 {
            get {
                return ResourceManager.GetString("String_faq1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 2. q. Откуда я могу получить идентификаторы своего устройства (HW_ID, OEM_ID, MODEL_ID, OEM_HASH)? а. Существует несколько программ, для обращения к памяти для запроса идентификаторов: - emmcdl с командой -info: - QLMCPUInfo; - QSaharaServer с командами command 02/03..
        /// </summary>
        internal static string String_faq2 {
            get {
                return ResourceManager.GetString("String_faq2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на https://github.com/hoplik/Firehose-Finder.
        /// </summary>
        internal static string String_help {
            get {
                return ResourceManager.GetString("String_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://4pda.ru/forum/index.php?showtopic=643084.
        /// </summary>
        internal static string String_theme_link {
            get {
                return ResourceManager.GetString("String_theme_link", resourceCulture);
            }
        }
    }
}
