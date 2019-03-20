#include <stdio.h>

#define MAZE_MIN_SIZE 1
#define MAZE_MAX_SIZE 100
#define DEFAULT_MAZE_REQ_SIZE 20

#ifdef MAZE_REQ_SIZE
 #if (MAZE_REQ_SIZE >= MAZE_MIN_SIZE)//si le paramètre est plus grand ou égal à 1
  #if (MAZE_REQ_SIZE % 2)//si le paramètre n'est pas un nombre pair
   #define MAZE_REQ_SIZE (MAZE_REQ_SIZE + 1)
  #endif
 #else 
  #define MAZE_REQ_SIZE DEFAULT_MAZE_REQ_SIZE //MAZE_REQ_SIZE = 20
 #endif
#else
  #define MAZE_REQ_SIZE DEFAULT_MAZE_REQ_SIZE // MAZE_REQ_SIZE = 20
#endif


#define MAZE_REAL_SIZE MAZE_REQ_SIZE

int maze[MAZE_REAL_SIZE][MAZE_REAL_SIZE];

int main(void)
{
printf("Maze␣size␣=␣%d\n", MAZE_REAL_SIZE);
return 0;
}
