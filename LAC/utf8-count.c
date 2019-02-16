/* Author	:	Tom Ryser
 * Project	:	utf8-count.c
 * Desc.	:	count the number of characters in utf8
 * Date		:	07.02.2019
 * */

#include <stdio.h>
#include "tests.h"

static signed int countCharacter(unsigned char s[])
{
    int result = -1, i, error = 0, first_octet, second_octet, third_octet, fourth_octet, fiveth_octet;

    for (i = 0; i < (int) strlen((char *)s); i++){
        first_octet = (int)s[i];
        second_octet = (int)s[i+1];
        third_octet = (int)s[i+2];
        fourth_octet = (int)s[i+3];
        fiveth_octet = (int)s[i+4];

        if ((first_octet < 128) && (first_octet > 32)){
            result++;
            if ((second_octet>=128) && (second_octet<192)){
                error = 1;
            }
        }else{
            if ((first_octet>=192) && (first_octet<224) && (second_octet>=128) && (second_octet<192)){
                result++;
                if ((third_octet>=128) && (third_octet<192)){
                    error = 1;
                }
            }
            if ((first_octet>=224) && (first_octet<240) && (second_octet>=128) && (second_octet<192)){
                if ((third_octet>=128) && (third_octet<192)){
                    result++;
                    if ((fourth_octet>=128) && (fourth_octet<192)){
                        error = 1;
                    }
                }else{
                    result= -1;
                }
            }
            if ((first_octet>=240) && (first_octet<248) && (second_octet>=128) && (second_octet<192)){
                if ((third_octet>=128) && (third_octet<192) && (fourth_octet>=128) && (fourth_octet<192)){
                    result++;
                    if ((fiveth_octet>=128) && (fiveth_octet<192)){
                        error = 1;
                    }
                }else{
                    result= -1;
                }
            }
        }
    }
    if (error == 1){
        result = -1;
    }
    if (result >= 0){
        result++;
    }else{
        result = -1;
    }
    //printf("%d\n", result);
    return result;
}


#ifdef UNIT_TESTS
START_TESTS()
START_TEST("UTF-8 string characters count")
{ /* this bracket is mandatory to permit the variables declaration in the block */

  unsigned char s1[]={'\041', '\101', '\132', '\000'};
  unsigned char s2[]={'\037', '\377', '\377', '\000'};
  unsigned char s3[]={'\357', '\200', '\255', '\000'};
  unsigned char s4[]={'\302', '\227', '\337', '\273', '\000'};
  unsigned char s5[]= {'\360', '\220', '\200', '\200', '\000'};
  unsigned char s6[]= {'\360', '\220', '\200', '\200', '\361', '\277',
                       '\277', '\277', '\000'
                        };
  unsigned char s7[]= {'\361', '\277', '\277', '\277', '\357', '\200',
                       '\255', '\337', '\273', '\065', '\000'
                      };
  unsigned char s8[]= {'\360', '\220', '\200', '\200', '\361', '\277',
                       '\277', '\000'
                      };

  unsigned char s9[]= {'\361', '\277', '\277', '\277', '\357', '\200',
                       '\255', '\337', '\273', '\065', '\200', '\000'
                      };

    /* s1 contains 3 valid UTF-8 characters */
    ASSERT(countCharacter(s1) == 3);
    
    /* s2 contains invalid UTF-8 characters */
    ASSERT(countCharacter(s2) == -1);

    /* s3 contains 1 valid UTF-8 character */
    ASSERT(countCharacter(s3) == 1);

    /* s4 contains 2 valid UTF-8 characters */
    ASSERT(countCharacter(s4) == 2);

    /* s5 contains 1 valid 4 bytes longs UTF-8 characters */
    ASSERT(countCharacter(s5) == 1);

    /* s6 contains 2 valid 4 bytes longs UTF-8 characters */
    ASSERT(countCharacter(s6) == 2);

    /* s7 contains 1 valid 4 bytes long UTF-8 characters, 1 valid 3 bytes long
      UTF-8 characters, 1 valid 2 bytes long UTF-8 characters and
      1 valid 1 byte long UTF-8 characters */
    ASSERT(countCharacter(s7) == 4);

    /* s8 is the same as s6 but with the last char unfinished */
    ASSERT(countCharacter(s8) == -1);

    /* s9 is the same as s7 but with "tail" character that musn't be here at the
       end of the string */
    ASSERT(countCharacter(s9) == -1);  
}
END_TEST()
END_TESTS()
#endif


