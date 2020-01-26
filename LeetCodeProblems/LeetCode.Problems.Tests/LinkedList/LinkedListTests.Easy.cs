using LeetCode.Problems.LinkedList;
using LeetCode.Problems.LinkedList.Easy;
using Xunit;

namespace LeetCode.Problems.Tests.LinkedList
{
	public partial class LinkedListTests
    {
        [Fact]
        public void LinkedListCycleProblemTest()
        {
            var solution = new LinkedListCycleProblem();
            var secondNode = new ListNode(2);

            var thirdNode = new ListNode(3)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5) { next = secondNode}
                }
            };
            secondNode.next = thirdNode;

            var head = new ListNode(1)
            {
                next = secondNode
            };

            Assert.True(solution.HasCycle(head));

            head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            Assert.False(solution.HasCycle(head));
            head = new ListNode(1);
            Assert.False(solution.HasCycle(head));
            Assert.False(solution.HasCycle(null));
        }

        [Fact]
        public void PalindromeLinkedListProblemTest()
        {
            var solution = new PalindromeLinkedListProblem();
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                        }
                    }
                }
            };
            Assert.True(solution.IsPalindrome(head));
            head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            Assert.False(solution.IsPalindrome(head));
            Assert.False(solution.IsPalindrome(null));

            head = new ListNode(1);
            Assert.True(solution.IsPalindrome(head));

            head = new ListNode(1)
            {
                next = new ListNode(2)
            };
            Assert.False(solution.IsPalindrome(head));
        }

	    [Fact]
	    public void ReverseLinkedListProblemTest()
	    {
		    var solution = new ReverseLinkedListProblem();

			var listNode = new ListNode(1)
		    {
			    next = new ListNode(2)
			    {
				    next = new ListNode(3)
				    {
					    next = new ListNode(4)
					    {
						    next = new ListNode(5)
						    {
							    next = null
						    }
					    }
				    }
			    }
		    };
		    var reversed = solution.ReverseList(listNode);
			Assert.Null(listNode.next);
			Assert.Equal(5, reversed.val);
			Assert.Equal(4, reversed.next.val);
	    }

		[Fact]
	    public void ReverseLinkedListIIProblemTest()
	    {
		    var solution = new ReverseLinkedListIIProblem();

			var listNode = new ListNode(1)
		    {
			    next = new ListNode(2)
			    {
				    next = new ListNode(3)
				    {
					    next = new ListNode(4)
					    {
						    next = new ListNode(5)
						    {
							    next = new ListNode(6)
						    }
					    }
				    }
			    }
		    };
		    var reversed = solution.ReverseBetween(listNode, 1, 3);
			Assert.Equal(3, reversed.val);
			Assert.Equal(2, reversed.next.val);
			Assert.Equal(1, reversed.next.next.val);
			Assert.Equal(4, reversed.next.next.next.val);

		    listNode = new ListNode(1)
		    {
			    next = new ListNode(2)
			    {
				    next = new ListNode(3)
				    {
					    next = new ListNode(4)
					    {
						    next = new ListNode(5)
						    {
							    next = new ListNode(6)
						    }
					    }
				    }
			    }
		    };

		    reversed = solution.ReverseBetween(listNode, 2, 3);
		    Assert.Equal(1, reversed.val);
		    Assert.Equal(3, reversed.next.val);
		    Assert.Equal(2, reversed.next.next.val);
		    Assert.Equal(4, reversed.next.next.next.val);
		}

		[Fact]
	    public void DeleteNodeinaLinkedListProblemTest()
		{
			var solution = new DeleteNodeinaLinkedListProblem();
			var list = new ListNode(4)
			{
				next = new ListNode(5)
				{
					next = new ListNode(1)
					{
						next = new ListNode(9)
					}
				}
			};
			solution.DeleteNode(list.next);
			Assert.Equal(1, list.next.val);
			Assert.Equal(4, list.val);
		}

	}
}
