# Serendipity

## Inspiration
**Problem Space:**
The digital age makes accessing information and doing more ‘easier’, but that doesn’t mean life is any easier.  Stressing out from the information overload is easy! 

Being in the know about what’s going on and acting on all the information from diverse sources, takes effort because the information given usually isn’t applicable in the moment. So you organize, and you schedule, or just try to remember. 

Can we understand what's going on around us in a delightful, intuitive?

**Goal:**
We are inspired to present relevant information when and where it would be actionable for people in a delightful, intuitive way. Let's bring a little more serendipity to daily life and make 'busy' less stressful.

**Interaction Goal:**
User goes about their life, and the application lets them know of relevant events according to their profile’s interests and various social medias, when and where the information is immediately actionable (time frame and location range can be adjusted to preferences). The events are shown embedded within a virtual 3D replica of the real environment simulated from your point of view. It is as if your phone was an xray for the world. 

For a more active interaction, if the user happens to realize they have free time, they can just as easily bring up the app and toggle time, space, and interest preferences for discovering events/interesting places. It’d make being a tourist/traveler less stressful.

(we believed 3D representation of the map would b e a more intuitive way for the user to understand the environment and spatial relationships. At any rate, it should be easier for most people to understand at a glance where something is if they understand the spatial context, rather than glancing at a flat 2D map in a bird's perspective)


**Meta Goal:** 
VR environments generated based off the real world, and informed by the user's live position in time and space, used to expand their understanding of what’s going on around them physically and temporally in order to ultimately augment the social, qualitative reality of their life.

## What we made
A working proof of concept that demonstrates how VR environments might be generated based off real world data and oriented to reflect the users location and orientation. 


## How it was built
Our proof of concept uses mapbox’s Unity sdk to generate a virtual model of the real world around the user’s live or inputted location. (Mapbox SDK provided map info like topography, floorplans, building elevations) The generation of the map model was tweaked to allow selection of individual buildings. The unity build for ios and android got the user's location information from the phone system and used compass data to orient the virtual environment (to script the angle and location of the camera in Unity) to match what we believed would be the user's point of view of the real world. We ran out of time to hook up the event spaces highlighted in the map to other API's, so the 'events' you see in the virtual world, aren't actually real.

## UI / Interaction prototyping
Early prototypes to help with ideation and understanding what sort of interaction we want were done with 360 photos (Ricoh Theta Camera), photoshopped, and thrown into Aframe to view on mobile. UI prototype was quickly shaped in Sketch and plopped into Origami.


## Challenges we ran into
It's always the little things that take time to solve. On a high level, the plan for how to execute wasn't particularly convoluted (mapbox, unity, ios/android and possible plumbing with social media API's/other sites to port event info in to a database) Getting started with Mapbox, and crash coursing Unity took a while and then the little bugs when building out for mobile kept us occupied.

## Accomplishments that I'm proud of
I'm pretty excited for the concept, and am proud about the ideating process. Otherwise, I'm very proud of the team;
we all sloughed through new material and it was a learning experience all around.

## What I learned
I should make design assets early/before the hackathon so that I can get more hands on coding experience while there are experienced developers around. (or not, it's hard to say; I had fun talking to people before deciding on running with an idea)

## What's next for Serendipity
Make it work! I want this for real to use! Polish the interaction, the Unity shaders, the UX, and the visual language. If we get far enough with it, then start testing for edge cases, and porting real data in, etc, etc.
Other than that....well the code is open source, so I want to see what other ideas people will have! 

