---
layout: post
title:  "Welcome to Jekyll!"
date:   2014-08-29 14:34:25
categories: jekyll update
tags: featured
image: /assets/article_images/2014-08-29-welcome-to-jekyll/desktop.jpg
---
You’ll find this post in your `_posts` directory. Go ahead and edit it and re-build the site to see your changes. You can rebuild the site in many different ways, but the most common way is to run `jekyll serve --watch`, which launches a web server and auto-regenerates your site when a file is updated.

To add new posts, simply add a file in the `_posts` directory that follows the convention `YYYY-MM-DD-name-of-post.ext` and includes the necessary front matter. Take a look at the source for this post to get an idea about how it works.

Jekyll also offers powerful support for code snippets:

```
def print_hi(name)
  puts "Hi, #{name}"
end
print_hi('Tom')
#=> prints 'Hi, Tom' to STDOUT.
```

Check out the [Jekyll docs][jekyll] for more info on how to get the most out of Jekyll. File all bugs/feature requests at [Jekyll’s GitHub repo][jekyll-gh]. If you have questions, you can ask them on [Jekyll’s dedicated Help repository][jekyll-help].

```js
<footer class="site-footer-mynkow-js">
 <a class="subscribe" href="{{ "/feed.xml" | prepend: site.baseurl }}"> <span class="tooltip"> <i class="fa fa-rss"></i> Subscribe!</span></a>
  <div class="inner">a
   <section class="copyright">All content copyright <a href="mailto:{{ site.email}}">{{ site.name }}</a> &copy; {{ site.time | date: '%Y' }} &bull; All rights reserved.</section>
   <section class="poweredby">Made with <a href="http://jekyllrb.com"> Jekyll</a></section>
  </div>
</footer>
```

```c#
public abstract class Publisher<TMessage> : IPublisher<TMessage> where TMessage : IMessage
{
    // static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Publisher<TMessage>));

    protected abstract bool PublishInternal(TMessage message, Dictionary<string, string> messageHeaders);

    public bool Publish(TMessage message, Dictionary<string, string> messageHeaders)
    {
        try
        {
            PublishInternal(message, messageHeaders);
            if (log.IsInfoEnabled)
                log.Info("PUBLISH => " + message);
            return true;
        }
        catch (Exception ex)
        {
            log.Error(ex.Message, ex);
            return false;
        }
    }
}
```

```html
<div class="header gist-header header-logged-in" role="banner">
  <div class="container clearfix">

    <a href="/" aria-label="Gist Homepage" class="header-logo-wordmark" data-hotkey="g d">
      <span class="mega-octicon octicon-logo-github"></span>
      <span class="mega-octicon octicon-gist-logo"></span>
</a>
    <div class="site-search js-site-search" role="search">
        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="✓"></div>
  <label class="js-chromeless-input-container form-control">
    <input type="text" class="js-site-search-focus chromeless-input js-navigation-enable js-quicksearch-field" data-hotkey="s" name="q" placeholder="Search…" tabindex="1" autocorrect="off" autocomplete="off" autocapitalize="off">
  </label>

    <div class="gist-quicksearch-results js-quicksearch-results js-navigation-container" data-quicksearch-url="/search/quick"></div>
</form>
    </div>
    <ul class="header-nav left" role="navigation">
      <li class="header-nav-item">
        <a href="/discover" class="header-nav-link" data-ga-click="Header, go to all gists, text:all gists">All gists</a>
      </li>

      <li class="header-nav-item">
        <a href="https://github.com" class="header-nav-link" data-ga-click="Header, go to GitHub, text:GitHub">GitHub</a>
      </li>
    </ul>

      <ul class="header-nav user-nav right" id="user-links">
        <li class="header-nav-item">
          <a href="/" class="btn btn-sm" data-ga-click="Header, go to new gist, text:new gist">New gist</a>
        </li>

        <li class="header-nav-item dropdown js-menu-container">
          <a class="header-nav-link name tooltipped tooltipped-s js-menu-target" href="#" aria-label="View profile and more" data-ga-click="Header, show menu, icon:avatar">
            <img alt="@mynkow" class="avatar" height="20" src="https://avatars3.githubusercontent.com/u/183151?v=3&amp;s=40" width="20">
            <span class="dropdown-caret"></span>
          </a>

          <div class="dropdown-menu-content js-menu-content">
            <div class="dropdown-menu dropdown-menu-sw">
              <div class="dropdown-header header-nav-current-user css-truncate">
                Signed in as <strong class="css-truncate-target">mynkow</strong>
              </div>
              <div class="dropdown-divider"></div>

              <a class="dropdown-item" href="/mynkow" data-ga-click="Header, go to your gists, text:your gists">
                Your gists
              </a>

              <a class="dropdown-item" href="/mynkow/starred" data-ga-click="Header, go to starred gists, text:starred gists">
                Starred gists
              </a>

              <a class="dropdown-item" href="https://help.github.com" data-ga-click="Header, go to help, text:help">
                Help
              </a>

              <div class="dropdown-divider"></div>

              <a class="dropdown-item" href="https://github.com/mynkow" data-ga-click="Header, go to profile, text:your profile">
                Your GitHub profile
              </a>

              <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="https://gist.github.com/auth/github/logout" class="logout-form" data-form-nonce="bc76147bfc7be47d5a5220b92e4f29fb0bc0a33a" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="✓"><input name="authenticity_token" type="hidden" value="8/Yx1zdbE6o0x/1rRWscqvpaPz1RpaYN8uuToE5JFxEM04IPU35gDRz8ThbDtWcDKQ5xwPcGx1ZOGA/84nKGfw=="></div>
                <button class="dropdown-item dropdown-signout" data-ga-click="Header, sign out, icon:logout">
                  Sign out
                </button>
</form>            </div>
          </div>
        </li>
      </ul>

  </div>
</div>
```

[jekyll]:      http://jekyllrb.com
[jekyll-gh]:   https://github.com/jekyll/jekyll
[jekyll-help]: https://github.com/jekyll/jekyll-help
