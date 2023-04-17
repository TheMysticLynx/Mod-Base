using System;
using System.Collections.Generic;
using Modding;

namespace Indev2
{
    public class Mod : IMod
    {
        public static Interface Interface;
        public string UniqueName => "Vanilla";
        public string DisplayName => "Vanilla(no mods)";
        public string Author => "Mystic";
        public string Version => "0.0.1UA";
        public string Description => "Vanilla(no mods)";
        public string[] Dependencies => Array.Empty<string>();

        public void Initialize(Modding.Interface @interface)
        {
            Interface = @interface;
        }

        public IEnumerable<CellProcessor> GetCellProcessors(ICellGrid cellGrid)
        {
            yield return new BasicCellProcessor(cellGrid);
            yield return new SlideCellProcessor(cellGrid);
            yield return new GeneratorCellProcessor(cellGrid);
            yield return new CWRotateProcessor(cellGrid);
            yield return new CCWRotateProcessor(cellGrid);
            yield return new MoverCellProcessor(cellGrid);
            yield return new WallCellProcessor(cellGrid);
            yield return new TrashCellProcessor(cellGrid);
            yield return new EnemyCellProcessor(cellGrid);
        }
    }
}