
singleton Material(lushgras_01_a_khl)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/environment/grass/lushgras_sparse_01_a.dds";
   diffuseColor[0] = "0.556863 0.521569 0.360784 1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "GroundCover";
   materialTag1 = "Grass";
};

singleton Material(lushgras_01_b_khl)
{
   mapTo = "lushgras_b_khl";
   diffuseMap[0] = "art/environment/grass/lushgras_sparse_01_b.dds";
   materialTag0 = "Grass";
   alphaTest = "1";
   alphaRef = "80";
   diffuseColor[0] = "0.623529 0.560784 0.380392 1";
   materialTag1 = "GroundCover";
   doubleSided = "1";
};

singleton Material(mossplant_01_quad)
{
   mapTo = "unmapped_mat";
   diffuseColor[0] = "0.560784 0.517647 0.0901961 1";
   diffuseMap[0] = "art/environment/moss/mossplant_01_quad.dds";
   alphaTest = "1";
   alphaRef = "80";
   doubleSided = "1";
   materialTag0 = "Plant";
   materialTag1 = "GroundCover";
};