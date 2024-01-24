# Jump_Chicken_Jump

## to see the game [Click Here](https://youtu.be/1-Exugukcr0)


### מטרת המשחק :

       משחק 1 נגד מחשב , התרנגול צריך לעבור את הכביש בלי להידרס על ידי מכוניות.

### מקשים :

       up - up arrow, down - down arrow, right - right arrow, left - left arrow.
### קישורים ל scripts :

תפקיד המחלקה CollisionLogger היא לשחקן - אחראית לניהול הטריגרים האפשריים בין התרנגול לשאר האובייקטים.
script - [click here](https://github.com/EladLaster/Jump_Chicken_Jump/blob/main/Assets/Scripts/CollisionLogger.cs)

תפקיד המחקלה DestroyOnTrigger2D היא לשחקן - גורמת לתרנגול למות ברגע שפגעה בו מכונית.
script - [click here](https://github.com/EladLaster/Jump_Chicken_Jump/blob/main/Assets/Scripts/DestroyOnTrigger2D.cs)

תפקיד המחלקה InputMover היא לשחקן - אחראית להליכה של התרנגול וגם לדילאי שלו בתחילת המשחק בשביל שמכוניות יתחילו ליסוע על הכביש ולהקשות עליו במעבר הכביש.
script - [click here](https://github.com/EladLaster/Jump_Chicken_Jump/blob/main/Assets/Scripts/InputMover.cs)

תפקיד המחלקה TimedSpawnerRandom היא למכוניות - אחראית לכניסה האקראית שלהם אל הכביש מ2 הכיוונים.
script - [click here](https://github.com/EladLaster/Jump_Chicken_Jump/blob/main/Assets/Scripts/TimedSpawnerRandom.cs)


תפקיד המחלקה Mover היא למכוניות - גורמת להם לזוז לכיוון מסויים במהירות מסויימת.

script - [click here](https://github.com/EladLaster/Jump_Chicken_Jump/blob/main/Assets/Scripts/Mover.cs)
