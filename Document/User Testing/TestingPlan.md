# Testing Plan for Interactive Prototype 3
Comprehensively, this project aims to use extended reality technology(VR specifically) to re-establish a 3D modeling environment that solves multiple pain points in traditional way as well as bringing immersive, interactive and simple way for user to experience and explore.  

## Testing Objective
By analyzing quantitative and qualitative data from the last two sprints, this iteration’s goal will focus on **building user guidance and tutorials**.  

### Hypothesis
User will perform each task successfully and smoothly with corresponding functionalities after finishing each tutorials.  

### Testing Goal
1. Test whether the user can finish each tutorials within certain times.
2. Test whether the user can perform each task successfully after finishing each tutorials.
3. Test if the current grabbing method(put cloned shapes into users’ hand directly) is better than the old one.
4. Test if the current sound effects are clear enough to let the user know that the action has been triggered successfully, deleting effect in this case.  

### Success Criteria
|Criteria| Score |
|-----|-----|
| Average time the user take to finish the tutorial from 1 to 5+ minutes. | Score 5 to 0 |
| Users have encountered 0 to 5+ problems during or after finishing the tutorial. | Score 5 to 0 |
| Users rate the new grabbing feature after completing the test. | Score 5 to 0 |
| Users rate the sound effects effectiveness after completing the test. | Score 5 to 0 |
If the total score is higher than 15/20, then this test meets its success criteria.  

## Testing Methodologies
Users testing process will be recorded by the headset. Video recordings will be analyzed to discover potential problems and record the time on task completion. After doing the test, users need to fill a questionnaire, rating specific using experience and provide feedback on specific questions.  

## Prototype Descriptions
The prototype was designed to provide interactive 3D object manipulation within a VR space to test user intuitiveness and smoothness.  
It allows users to grab, move, rotate, scale, delete and control the gravity of primitive shapes using VR controllers.  
The environment includes a medieval style virtual workspace, a workbench with sample shapes, and gesture based transformations.  

## Data Collection Method
This test will use ‘Time on Task’ to measure the quantitative time each users take to finish designed tasks, and use ‘Audio Recording’ to record user’s reaction and combine with the video recordings. Users are encouraged to talk during the test period.  

## Testing Setup

### Equipment
Meta Quest 2 or 3  
Unity Project with version 2022.3.62f  
Meta Quest Link to retreat video recording  
A audio recording device.  

## Testing Process
1. Verbal description and project concept introduction - Explain the project aim and purpose
2. Inform user how to operate the equipment.
3. Tutorial (Estimate of 3 - 5min)
4. Task performance (Estimate of 5 - 8min)
5. Filling the questionnaire.
6. A little conversation about user’s feeling.

## Research Paragraph
This testing plan aims to move traditional 3D modeling from 2D desktop software into an immersive XR environment to address issues such as limited viewpoints and camera control. Studies have shown that immersive environments bring new challenges, including reduced precision and visibility problems caused by occlusion.  

The first objective of this testing phase is to move the 3D-modelling environment from a 2D PC interface into an immersive XR space, thereby tackling issues such as restricted viewpoints and camera-movement blockages. In practice, when the camera moves into tight clusters of objects the collision volumes may overlap and the camera can become stuck, forcing the user to move or remove objects before proceeding. Research on occlusion and viewpoint constraints in VR supports this: Wang et al. found that occlusions and limited navigation corridors reduce user exploration efficiency in VR scenes [1].  

The second concern is the steep barrier to entry found in traditional modelling software. Legacy tools like CAD and Maya often require substantial time and effort before users become comfortable. Without sufficient guidance, participants in our second user test experienced critical difficulties: one user mis-understood the trigger condition for a modelling function and became highly frustrated with the task. Empirical work shows that novices learning 3D modelling tools struggle significantly with usability and workflow complexity [2].  

The third focus is accuracy in XR interactions, especially for two-handed and non-uniform scaling operations. In the second round of tests, users found it difficult to isolate a single axis during asymmetric scaling: even a slight tremor would cause unwanted scaling along other axes, reducing control and precision. Recent work confirms that VR hand-object interactions still suffer from imprecise grasps, erratic object responses and reduced performance in precision tasks [3].  

## Reference List
[1] L. Wang, “Occlusion Management in VR: A Comparative Study,” Proc. IEEE Virtual Reality and 3D User Interfaces, 2019. Available: https://www.cs.purdue.edu/cgvlab/www/resources/papers/Wang-IEEE-2019-Occlusion_Management_in_VR_A_Comparative_Study.pdf  
[2] H. Hsinfu Huang and C.-F. Lee, “Factors Affecting Usability of 3D Model Learning in a Virtual Reality Environment,” Interactive Learning Environments, vol. 30, no. 5, pp. 848-861, 2022.  
[3] M. Mangalam, S. Oruganti, G. Buckingham & C. Borst, “Enhancing hand-object interactions in virtual reality for precision manual tasks,” Virtual Reality, vol. 28, article 166, 2024. Available: https://link.springer.com/article/10.1007/s10055-024-01055-3  
