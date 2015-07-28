
singleton TSShapeConstructor(Lilac_01_aDae)
{
   baseShape = "./lilac_01_a.dae";
};

function Lilac_01_aDae::onLoad(%this)
{
   %this.addImposter("32", "6", "0", "0", "128", "0", "0");
}
