//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
//	Sounds
//-----------------------------------------------------------------------------


singleton SFXDescription( MinorExplosionSFXDesc : AudioEffect )
{
   is3D              = true;
   ReferenceDistance = 15.0;
   MaxDistance       = 100.0;
};

datablock SFXProfile(MinorExplosionSound)
{
filename = "art/sound/grenade_explosion";
description = MinorExplosionSFXDesc;
preload = true;
};


//-----------------------------------------------------------------------------
//	Particles
//-----------------------------------------------------------------------------

datablock ParticleData(GroundMinorBlast1)
{
   textureName          = "art/shapes/particles/FXpack1/dirtblast02";
   dragCoefficient      = 5;
   gravityCoefficient   = 0.0;
   inheritedVelFactor   = 0.2;
   windCoefficient      = 0;
   constantAcceleration = 0;
   lifetimeMS           = 600;
   lifetimeVarianceMS   = 400;
   spinRandomMin = -20.0;
   spinRandomMax =  20.0;
   useInvAlpha   = true;

   colors[0]     = "1.0 0.9 0.8 0.2"; 
   colors[1]     = "0.9 0.8 0.7 0.4";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 8.0;
   sizes[1]      = 12.0;
   sizes[2]      = 16.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorBlast1Emitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;
   ejectionVelocity = 60.0;
   velocityVariance = 0.5;
   ejectionOffset   = 0.4;
   thetaMin         = 10;
   thetaMax         = 60;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   orientParticles  = true;
   orientOnVelocity = true;
   particles = "GroundMinorBlast1";
};

datablock ParticleData(GroundMinorBlast2)
{
   textureName          = "art/shapes/particles/FXpack1/dirtblast01";
   dragCoefficient      = 5;
   gravityCoefficient   = 0.0;
   inheritedVelFactor   = 0.2;
   windCoefficient      = 0;
   constantAcceleration = 0;
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 300;
   spinRandomMin = -20.0;
   spinRandomMax =  20.0;
   useInvAlpha   = true;

   colors[0]     = "1.0 0.9 0.8 0.3"; 
   colors[1]     = "0.9 0.8 0.7 1.0";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 8.0;
   sizes[1]      = 16.0;
   sizes[2]      = 30.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorBlast2Emitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 4;
   ejectionVelocity = 65.0;
   velocityVariance = 0.5;
   ejectionOffset   = 0.4;
   thetaMin         = 10;
   thetaMax         = 60;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   orientParticles  = true;
   orientOnVelocity = true;
   particles = "GroundMinorBlast2";
};


datablock ParticleData(GroundMinorDirt)
{
   textureName          = "art/shapes/particles/FXpack1/rocks";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = 5.0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1200;
   lifetimeVarianceMS   = 800;
   useInvAlpha =  true;
   spinRandomMin = -180.0;
   spinRandomMax =  180.0;

   colors[0]     = "1.0 0.8 0.6 0.3"; 
   colors[1]     = "0.3 0.3 0.3 0.7";
   colors[2]     = "0.3 0.3 0.3 0.0";

   sizes[0]      = 1.0;
   sizes[1]      = 1.6;
   sizes[2]      = 2.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorDirtEmitter)
{
   ejectionPeriodMS = 4;
   periodVarianceMS = 2;
   ejectionVelocity = 35.0;
   velocityVariance = 5.0;
   thetaMin         = 0.0;
   thetaMax         = 10.0;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   particles = "GroundMinorDirt";
};

datablock ParticleData(GroundMinorSubFireball)
{
   textureName          = "art/shapes/particles/FXpack1/explosion";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = -5.5;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 400;
   lifetimeVarianceMS   = 100;
   useInvAlpha =  false;
   spinRandomMin = -280.0;
   spinRandomMax =  280.0;

   colors[0]     = "1.0 0.9 0.8 0.1";
   colors[1]     = "1.0 0.5 0.0 0.3";
   colors[2]     = "0.1 0.1 0.1 0.0";

   sizes[0]      = 6.0;
   sizes[1]      = 12.0;
   sizes[2]      = 10.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorSubFireballEmitter)
{
   ejectionPeriodMS = 50;
   periodVarianceMS = 20;
   ejectionVelocity = 5.0;
   velocityVariance = 1.0;
   thetaMin         = 0.0;
   thetaMax         = 60.0;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   ejectionoffset   = 5;
   particles = "GroundMinorSubFireball";
};

datablock ParticleData(GroundMinorSubDust)
{
   textureName          = "art/shapes/particles/FXpack1/dirt";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = 4.0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1200;
   lifetimeVarianceMS   = 800;
   useInvAlpha =  true;
   spinRandomMin = -60.0;
   spinRandomMax =  60.0;

   colors[0]     = "1.0 0.8 0.6 0.8"; 
   colors[1]     = "0.3 0.3 0.3 0.5";
   colors[2]     = "0.1 0.1 0.1 0.0";

   sizes[0]      = 4.0;
   sizes[1]      = 8.0;
   sizes[2]      = 12.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorSubDustEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;
   ejectionVelocity = 30.0;
   velocityVariance = 5.0;
   thetaMin         = 0.0;
   thetaMax         = 30.0;
   particles = "GroundMinorSubDust";
};


datablock ParticleData(GroundMinorVolume)
{
   textureName          = "art/shapes/particles/FXpack1/smoke01";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = -0.4;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1200;
   lifetimeVarianceMS   = 800;
   useInvAlpha =  true;
   spinRandomMin = -80.0;
   spinRandomMax =  80.0;

   colors[0]     = "1.0 0.8 0.6 0.0"; 
   colors[1]     = "0.3 0.3 0.3 0.7";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 8.0;
   sizes[1]      = 12.0;
   sizes[2]      = 16.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorVolumeEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;
   ejectionVelocity = 4.8;
   velocityVariance = 2.0;
   thetaMin         = 0.0;
   thetaMax         = 180.0;
   lifetimeMS       = 250;
   particles = "GroundMinorVolume";
};

datablock ParticleData(GroundMinorPoint)
{
   textureName          = "art/shapes/particles/FXpack1/explosion";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = -0.5;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 200;
   useInvAlpha =  false;
   spinRandomMin = -180.0;
   spinRandomMax =  180.0;

   colors[0]     = "1.0 0.9 0.8 0.9";
   colors[1]     = "0.8 0.4 0 0.2";
   colors[2]     = "0.0 0.0 0.0 0.0";

   sizes[0]      = 6.0;
   sizes[1]      = 14.0;
   sizes[2]      = 2.0;

   times[0]      = 0.0;
   times[1]      = 0.35;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GroundMinorPointEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;
   ejectionVelocity = 3;
   velocityVariance = 2;
   thetaMin         = 0;
   thetaMax         = 90;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   particles = "GroundMinorPoint";
};


//-----------------------------------------------------------------------------
//	Explosions
//-----------------------------------------------------------------------------


datablock ExplosionData(GroundMinorSubExplosion1)
{
   lifeTimeMS = 100;
   offset = 0;
   emitter[0] = GroundMinorBlast1Emitter;  
   emitter[1] = GroundMinorBlast2Emitter;  
   emitter[2] = GroundMinorDirtEmitter;  
};


datablock ExplosionData(GroundMinorSubExplosion2)
{
   lifeTimeMS = 100;
   offset = 2;
   emitter[0] = GroundMinorSubFireballEmitter; 
   emitter[1] = GroundMinorSubDustEmitter; 
};


datablock ExplosionData(GroundMinorSubExplosion3)
{
   lifeTimeMS = 100;
   offset = 3;
   emitter[0] = GroundMinorSubFireballEmitter;  
   emitter[1] = GroundMinorSubDustEmitter;
};


datablock ExplosionData(GroundMinorExplosion)
{
   soundProfile = MinorExplosionSound;
   lifeTimeMS = 120; 

   // Volume
   particleEmitter = GroundMinorVolumeEmitter;
   particleDensity = 30;
   particleRadius = 1.5;

   // Point emission
   emitter[0] = GroundMinorPointEmitter; 
   emitter[1] = GroundMinorSubFireballEmitter; 

   // Sub explosions
   subExplosion[0] = GroundMinorSubExplosion1;
   subExplosion[1] = GroundMinorSubExplosion2;
   subExplosion[2] = GroundMinorSubExplosion3;
   
   lightStartRadius = 18;
   lightEndRadius = 8;
   lightStartColor = "0.7 0.5 0.3 1";
   lightEndColor = "0 0 0 0";  
      
    // Camera Shaking
    shakeCamera = true;
    camShakeFreq = "10.0 11.0 9.0";
    camShakeAmp = "10.0 10.0 10.0";
    camShakeDuration = 1.5;
    camShakeRadius = 15;
};