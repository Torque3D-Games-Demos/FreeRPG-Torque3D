new TerrainMaterial()
{
   diffuseMap = "art/terrains/ExampleTerrains/grass_example_base";
   detailMap = "art/terrains/ExampleTerrains/grass_example_detail";
   parallaxScale = "0.14";
   internalName = "grass_example";
   diffuseSize = "350";
   macroSize = "60";
   macroStrength = "0.5";
   macroDistance = "500";
   detailSize = "3";
   detailDistance = "100";
   macroMap = "art/terrains/ExampleTerrains/grass_example_macro";
   normalMap = "art/terrains/ExampleTerrains/grass_example_normal";
};

singleton Material(TerrainFX_grass_example)  
{  
   mapTo = "grass_example";  
   footstepSoundId = 0;  
   terrainMaterials = "1";  
   ShowDust = "false";  
   showFootprints = "false"; 
   materialTag0 = "Terrain"; 
};  

new TerrainMaterial()
{
   diffuseMap = "art/terrains/ExampleTerrains/sand_example_base";
   diffuseSize = "250";
   detailMap = "art/terrains/ExampleTerrains/sand_example_detail";
   detailDistance = "100";
   internalName = "sand_example";
   macroStrength = "0.8";
   macroSize = "50";
   detailSize = "3";
   normalMap = "art/terrains/ExampleTerrains/sand_example_normal";
   parallaxScale = "0.1";
   macroMap = "art/terrains/ExampleTerrains/sand_example_macro";
};

singleton Material(TerrainFX_sand_example)  
{  
   mapTo = "sand_example";  
   footstepSoundId = 0;  
   terrainMaterials = "1";  
   ShowDust = "false";  
   showFootprints = "false"; 
   materialTag0 = "Terrain"; 
};  

new TerrainMaterial()
{
   diffuseMap = "art/terrains/ExampleTerrains/rock_example_base";
   diffuseSize = "250";
   detailMap = "art/terrains/ExampleTerrains/rock_example_detail";
   detailDistance = "100";
   macroSize = "100";
   internalName = "rock_example";
   detailSize = "5";
   macroStrength = "0.7";
   normalMap = "art/terrains/ExampleTerrains/rock_example_normal";
   parallaxScale = "0.12";
   detailStrength = "1";
   macroMap = "art/terrains/ExampleTerrains/rock_example_macro";
};

singleton Material(TerrainFX_rock_example)  
{  
   mapTo = "rock_example";  
   footstepSoundId = 0;  
   terrainMaterials = "1";  
   ShowDust = "false";  
   showFootprints = "false"; 
   materialTag0 = "Terrain"; 
};  

new TerrainMaterial()
{
   diffuseMap = "art/terrains/ExampleTerrains/rock_example_base";
   diffuseSize = "250";
   detailMap = "art/terrains/ExampleTerrains/rock_example_detail";
   detailDistance = "100";
   macroSize = "100";
   internalName = "rock_example_side";
   detailSize = "6";
   macroStrength = "0.7";
   normalMap = "art/terrains/ExampleTerrains/rock_example_normal";
   parallaxScale = "0.12";
   detailStrength = "1.2";
   macroMap = "art/terrains/ExampleTerrains/rock_example_macro";
   useSideProjection = "1";
};

singleton Material(TerrainFX_rock_example_side)  
{  
   mapTo = "rock_example_side";  
   footstepSoundId = 0;  
   terrainMaterials = "1";  
   ShowDust = "false";  
   showFootprints = "false"; 
   materialTag0 = "Terrain"; 
};  

new TerrainMaterial()
{
   diffuseMap = "art/terrains/ExampleTerrains/forest_example_base";
   diffuseSize = "250";
   detailMap = "art/terrains/ExampleTerrains/forest_example_detail";
   detailDistance = "100";
   macroMap = "art/terrains/ExampleTerrains/forest_example_macro";
   macroSize = "50";
   internalName = "forest_example";
   detailSize = "3";
   macroStrength = "0.8";
   parallaxScale = "0.05";
   normalMap = "art/terrains/ExampleTerrains/forest_example_normal";
};

singleton Material(TerrainFX_forest_example)  
{  
   mapTo = "forest_example";  
   footstepSoundId = 0;  
   terrainMaterials = "1";  
   ShowDust = "false";  
   showFootprints = "false"; 
   materialTag0 = "Terrain"; 
};  

new TerrainMaterial()
{
   diffuseMap = "art/terrains/ExampleTerrains/gravel_example_base";
   diffuseSize = "250";
   detailMap = "art/terrains/ExampleTerrains/gravel_example_detail";
   detailDistance = "100";
   macroSize = "16";
   internalName = "gravel_example";
   detailSize = "3";
   macroStrength = "1";
   parallaxScale = "0.09";
   normalMap = "art/terrains/ExampleTerrains/gravel_example_normal";
   macroMap = "art/terrains/ExampleTerrains/gravel_example_macro";
};

singleton Material(TerrainFX_gravel_example)  
{  
   mapTo = "gravel_example";  
   footstepSoundId = 0;  
   terrainMaterials = "1";  
   ShowDust = "false";  
   showFootprints = "false"; 
   materialTag0 = "Terrain"; 
};  
