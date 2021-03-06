﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA.AnalogView.AnalogParametrs.AnalogInterfaces
{
    interface IPLCAnalogValue
    {
        /// <summary>
        /// натстройка тегов для чтения с контроллера
        /// </summary>
        /// <param name="ADCTag">тег для кодов АЦП</param>
        /// <param name="PLCValueTag">тег для текущего значения</param>
        /// <param name="AnalogState">тег для текущего состояния</param>
        void SetAnalogTags(string ADCTag, string PLCValueTag, string AnalogState);
        /// <summary>
        /// Чтение текущего значения аналогового сигнала
        /// </summary>
        /// <param name="value">ссылка на представление аналогового сигнала</param>
        void GetCurrentAnalogValue(ref AnalogValue value);
        /// <summary>
        /// Подписка на изменение значений аналогового сигнала
        /// </summary>
        /// <param name="value">Ссылка на предсталение аналогового сигнала</param>
        void SubscribeToChangeAnalogValue(ref AnalogValue value);

        /// <summary>
        /// Установить командные теги
        /// </summary>
        /// <param name="idTag">тег индекс сигнала</param>
        /// <param name="cmdTag">тег команда</param>
        /// <param name="valueTag">тег значение</param>
        void SetCmdTags(string idTag, string cmdTag, string valueTag);
        /// <summary>
        /// команда в контроллер установить имитацию
        /// </summary>
        /// <param name="ImitValue"></param>
        void CmdSetImit(float ImitValue, uint id);
        /// <summary>
        /// Команда в контроллер снять имитацию
        /// </summary>
        void CmdUnsetImit(uint id);
        /// <summary>
        /// Команда в контроллер записать новое значение имитации
        /// </summary>
        /// <param name="ImitValue"></param>
        void CmdChangeImitValue(float ImitValue, uint id);
    }
}
