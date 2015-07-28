
singleton Material(road_asphalt_stripes)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/roads/d_road_asphalt_stripes_diffuse.dds";
   normalMap[0] = "art/roads/d_road_asphalt_stripes_normal.dds";
   specularPower[0] = "1";
   specularMap[0] = "art/roads/d_road_asphalt_stripes_specular.dds";
   translucent = "1";
   translucentZWrite = "1";
   diffuseColor[0] = "0.705882 0.705882 0.705882 1";
   materialTag0 = "RoadAndPath";
};

singleton Material(grass_small_gsm01)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/grass_dry_short_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "70";
   diffuseColor[0] = "0.670588 0.745098 0.537255 1";
   specularPower[0] = "24";
   castShadows = "0";
   materialTag0 = "Grass";
   specularMap[0] = "art/environment/grass/grass_dry_short_01_specular.dds";
   normalMap[0] = "art/environment/grass/grass_dry_short_01_normal.dds";
   materialTag1 = "GroundCover";
};

singleton Material(grass_tall_gsm01)
{
   mapTo = "unmapped_mat";
   diffuseColor[0] = "0.701961 0.741176 0.537255 1";
   diffuseMap[0] = "art/environment/grass/grass_dry_tall_01.dds";
   normalMap[0] = "art/environment/grass/grass_dry_tall_01_normal.dds";
   specularMap[0] = "art/environment/grass/grass_dry_tall_01_specular.dds";
   alphaTest = "1";
   alphaRef = "67";
   specularPower[0] = "16";
   castShadows = "0";
   materialTag0 = "Grass";
   materialTag1 = "GroundCover";
};

singleton Material(grass_medium_gsm01)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/grass_dry_medium_01.dds";
   normalMap[0] = "art/environment/grass/grass_dry_medium_01_normal.dds";
   specularMap[0] = "art/environment/grass/grass_dry_medium_01_specular.dds";
   alphaTest = "1";
   alphaRef = "67";
   diffuseColor[0] = "0.615686 0.678431 0.533333 1";
   specularPower[0] = "16";
   castShadows = "0";
   materialTag1 = "GroundCover";
   materialTag0 = "Grass";
};

singleton Material(poplar_bark_01)
{
   mapTo = "poplar_bark_01";
   diffuseMap[0] = "art/shapes/trees/poplar/poplar_01/poplar_01_bark_diffuse.dds";
   materialTag0 = "Bark";
};

singleton Material(lilac_01_bark_mat)
{
   mapTo = "lilac_01_bark";
   diffuseMap[0] = "art/shapes/trees/poplar/poplar_01/poplar_01_bark_diffuse.dds";
   diffuseColor[0] = "0.819608 0.776471 0.678431 1";
};

singleton Material(grass_lush_soft_01_a)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/grass_lush_soft_01_a.dds";
   diffuseColor[0] = "0.588235 0.607843 0.505882 1";
   normalMap[0] = "art/environment/grass/grass_lush_soft_01_a_normal.dds";
   specularPower[0] = "16";
   specularMap[0] = "art/environment/grass/grass_lush_soft_01_a_specular.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag1 = "GroundCover";
   materialTag0 = "Grass";
};

singleton Material(grass_lush_soft_01_b)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/grass_lush_soft_01_b.dds";
   materialTag0 = "Grass";
   diffuseColor[0] = "0.584314 0.611765 0.47451 1";
   translucent = "0";
   alphaRef = "100";
   alphaTest = "1";
   doubleSided = "1";
   specularPower[0] = "16";
   normalMap[0] = "art/environment/grass/grass_lush_soft_01_b_normal.dds";
   specularMap[0] = "art/environment/grass/grass_lush_soft_01_b_specular.dds";
   materialTag1 = "GroundCover";
};

singleton Material(beargrassflowerwhite)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/flowers/beargrass_flower_01_white.dds";
   alphaTest = "1";
   alphaRef = "40";
   doubleSided = "1";
   diffuseColor[0] = "0.658824 0.682353 0.552941 1";
   materialTag0 = "GroundCover";
};

singleton Material(crocuspurple)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/flowers/crocus_small_purple.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
    materialTag0 = "GroundCover";
};

singleton Material(crocusyellow)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/flowers/crocus_small_yellow.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
   materialTag0 = "GroundCover";
   diffuseColor[0] = "0.909804 0.909804 0.909804 1";
};

singleton Material(crocuswhite)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/flowers/crocus_small_white.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
   materialTag0 = "GroundCover";
   diffuseColor[0] = "0.807843 0.807843 0.807843 1";
};

singleton Material(foxtails_01)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/foxtails_01.dds";
   alphaTest = "1";
   alphaRef = "40";
   doubleSided = "1";
   diffuseColor[0] = "0.647059 0.647059 0.647059 1";
   materialTag0 = "Grass";
   materialTag1 = "GroundCover";
};

singleton Material(sorrel_01_a)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/herbs/sorrel_01_a.dds";
   diffuseColor[0] = "0.780392 0.745098 0.568627 1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "GroundCover";
};

singleton Material(sorrel_01_b)
{
   mapTo = "unmapped_mat";
   diffuseColor[0] = "0.643137 0.588235 0.443137 1";
   diffuseMap[0] = "art/environment/herbs/sorrel_01_b.dds";
   doubleSided = "1";
   castShadows = "0";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "GroundCover";
};

singleton Material(foxtails_01_wo)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/foxtails_01_wo.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   diffuseColor[0] = "0.435294 0.494118 0.184314 1";
   materialTag0 = "GroundCover";
};

singleton Material(Cloth)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/shapes/props/cloth/sheerfabric_diffuse.dds";
   normalMap[0] = "sheerfabric_normal.png";
   doubleSided = "1";
   materialTag0 = "RoadAndPath";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "161";
};