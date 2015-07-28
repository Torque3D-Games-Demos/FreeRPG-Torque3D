
singleton Material(grain1_Grain)
{
   mapTo = "Grain";
   specular[0] = "0.02 0.02 0.02 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(grain1_ClothDark)
{
   mapTo = "ClothDark";
   diffuseMap[0] = "ClothDark";
   normalMap[0] = "ClothDark";
   specular[0] = "0.01 0.01 0.01 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};
