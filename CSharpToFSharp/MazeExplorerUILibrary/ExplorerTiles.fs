﻿module ExplorerTiles

let createCardinal background foreground =
    [(Cardinal.North,ExplorerPatterns.ExplorerN);
    (Cardinal.East,ExplorerPatterns.ExplorerE);
    (Cardinal.South,ExplorerPatterns.ExplorerS);
    (Cardinal.West,ExplorerPatterns.ExplorerW)]
    |> Seq.map (fun (k,p) -> (k, new Tile.Tile(p,background,foreground)))
    |> Map.ofSeq


