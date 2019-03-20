/*
*07.01.2019
*tom RYSER
*ryser_bouncing_ball.c
*program that display a "*" that bounce around the window.
*/

#include <stdlib.h>
#include <ncurses.h>
#include <unistd.h>


#define DELAY 30000
#define SPEED -1
#define ZERO 0

int main(int argc, char *argv[]) {
 int x = 0, y = 0;
 int max_y = 0, max_x = 0;
 int next_y = 0, next_x = 0;
 int direction_x = 1;
 int direction_y = 1;
 

 //initialise the screen of ncurses
 initscr();
 noecho();
 curs_set(FALSE);

 while(1) {
  // get size of terminal window.  
  getmaxyx(stdscr, max_y, max_x);
  clear();
  mvprintw(y, x, "*");
  refresh();
  usleep(DELAY);

  //get prevision of position to detect collision with the border of the window
  next_x = x + direction_x;
  next_y = y + direction_y;

  //test if the next position is colliding with the border of the window
  //test for the right and left of the window
  if (next_x >= max_x || next_x < ZERO) {
   direction_x*= SPEED;
  } else {
   x+= direction_x;
  }
  //test for the top and bottom of the window
  if (next_y >= max_y || next_y < ZERO) {
   direction_y*= SPEED;
  } else {
   y+= direction_y;
  }
  //test if the user resize the window and hide the ball outside the window
  if(x >= max_x){
     x = max_x;
  }
  if(y >= max_y){
     y = max_y;
  }
 }
}